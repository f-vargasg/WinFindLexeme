create or replace PACKAGE BODY <%packageName> IS
-- Funcion para determinar que un registro existe tabla <%tableName>
FUNCTION EXISTE (<%paramKeyFlds>) RETURN Number
IS
    Wse_existe Number;
BEGIN

   select count(1) into Wse_existe
   from dual
   where exists (
    Select count(*)
    Into Wse_existe
    From <%tableName>
    Where 	<%compareKeys>
    );

    return Wse_existe;

EXCEPTION
    When others then
        Ge_PAmbonError.Grabarerror(997, 'Exception: Problemas al Validar [<%packageName>.EXISTE]',sqlerrm);
END EXISTE;
----------------------------------------------------------------
-- Consecutivo Global para la Tabla <%tableName>
FUNCTION CONSECUTIVO
RETURN NUMBER IS
--
    wRes NUMBER(8);
--
BEGIN


    Return wRes;

EXCEPTION
    when no_data_found then
        return 1;
    When others then
        Ge_PAmbonError.Grabarerror(997, 'EXCEPTION: Problemas Obtiendo Consecutivo [<%packageName>.CONSECUTIVO]',sqlerrm);
        return null;
END CONSECUTIVO;

----------------------------------------------------------------
-- Procedimiento de insercion en la tabla <%tableName>
-- cod_estadofirma_n .- 1 Firmado
PROCEDURE INSERTA (<%insertParams>
                   pFEC_INGRESO       IN DATE     DEFAULT SYSDATE,
                   pCOD_USUARIOREG_V  IN VARCHAR2
) IS

BEGIN


    wcod_registro := GE_PAMBCOMMON.CONSECUTIVO;

     Insert Into <%tableName>(<%tblInsertFlds>)
     Values (<%paramsToInserta>);



    GE_PAMBBITOBJETO.registrar(pcod_accionreg_n     => 1,
                               pdes_tabla           => '<%tableName>',
                               pcod_registro_n      => wcod_registro,
                               pcod_usuario_v       => pCOD_USUARIOREG_V);

EXCEPTION
    When others then
      Ge_PAmbonError.Grabarerror(997, 'Exception: Problemas al Insertar [<%packageName>.INSERTA]',sqlerrm);
    END INSERTA;
----------------------------------------------------------------
-- Procedimiento de modificacion en la tabla
PROCEDURE MODIFICA (<%modifyParams>,
                    pCOD_USUARIOREG_V IN VARCHAR2,
                    pCOD_REGISTRO_N IN NUMBER,
                    PNUM_VERSION IN NUMBER
) IS
BEGIN
    UPDATE <%tableName>
    SET <%tblModifyFlds>
    WHERE <%compareKeys>;


    GE_PAMBBITOBJETO.registrar(pcod_accionreg_n     => 3,
                               pdes_tabla           => '<%tableName>',
                               pcod_registro_n      => pCOD_REGISTRO_N,
                               pcod_usuario_v       => pCOD_USUARIOREG_V,
                               pnum_version         => pnum_version);

EXCEPTION
    When others then
      Ge_PAmbonError.Grabarerror(997, 'Exception: Problemas al Modificar [<%packageName>.MODIFICA]',sqlerrm);
END MODIFICA;
   ----------------------------------------------------------------

-- Procedimiento de Borrado en la tabla <%tableName>
PROCEDURE BORRA (<%paramKeyFlds>,
                 pCOD_USUARIOREG_V IN VARCHAR2,
                 pCOD_REGISTRO_N IN NUMBER)
IS
BEGIN

    DELETE FROM <%tableName>
    WHERE 	<%compareKeys>;


    GE_PAMBBITOBJETO.registrar(pcod_accionreg_n     => 4,
                               pdes_tabla           => '<%tableName>',
                               pcod_registro_n      => pCOD_REGISTRO_N,
                               pcod_usuario_v       => pCOD_USUARIOREG_V);
EXCEPTION
    When others then
        Ge_PAmbonError.Grabarerror(997, 'Exception: Problemas al Borrar [<%packageName>.BORRA]',sqlerrm);
END BORRA;
----------------------------------------------------------------
-- Procedimiento para cambiar de estado en la <%tableName>
PROCEDURE CAMBIA_ESTADO (<%paramKeyFlds>,
                         pCOD_ESTADO_N IN NUMBER,
                         pCOD_USUARIOREG_V IN VARCHAR2,
                         pCOD_REGISTRO_N IN NUMBER,
                         PNUM_VERSION IN NUMBER
) IS
BEGIN

    UPDATE <%tableName>
    SET cod_estado_n = pcod_estado_n
    WHERE 	<%compareKeys>;

    GE_PAMBBITOBJETO.registrar(pcod_accionreg_n     => 2,
                               pdes_tabla           => '<%tableName>',
                               pcod_registro_n      => pCOD_REGISTRO_N,
                               pcod_usuario_v       => pCOD_USUARIOREG_V,
                               pcod_estado_n        => pCOD_ESTADO_N,
                               PNUM_VERSION         => PNUM_VERSION);


EXCEPTION
    When others then
        Ge_PAmbonError.Grabarerror(997, 'Exception: Problemas al Cambiar Estado [<%packageName>.CAMBIA_ESTADO]',sqlerrm);
END CAMBIA_ESTADO;

----------------------------------------------------------------
-- Procedimiento que lee tabla por primary key.
-- Retorna un registro de tipo documento
FUNCTION LeerRegistroPorPK (<%paramKeyFlds>,
                            pBlockReg       IN BOOLEAN DEFAULT FALSE,
                            pIndValidaExist IN VARCHAR2 DEFAULT 'S'
) RETURN <%tableName>%ROWTYPE
IS
--
  wexcepcion EXCEPTION;
  wmsg VARCHAR2(500);
  wres <%tableName>%ROWTYPE;
--
BEGIN
    BEGIN
        IF pBlockReg THEN
            SELECT A.*
            Into wRes
            FROM    <%tableName> A
            WHERE   <%compareKeys>
            FOR UPDATE;
        ELSE -- no blocking
            SELECT A.*
            INTO wRes
            FROM    <%tableName> A
            WHERE   <%compareKeys>;
        END IF;
    EXCEPTION
      WHEN NO_DATA_FOUND THEN
         IF pIndValidaExist = 'S' THEN
              wmsg := 'Registro no encontrado en tabla <%tableName> con llave ' || <%printLstKeys>;
              RAISE wexcepcion;
         END IF;
      WHEN others then
         wmsg := 'Ocurrio una excepcion en tabla <%tableName>';
         RAISE wexcepcion;
    END;
    RETURN wres;
EXCEPTION
    WHEN wExcepcion THEN
       Ge_PAmbOnError.Grabarerror(997, wmsg ||  'Excepcion en [<%tableName>.LeerRegistroPorPK]',sqlerrm);
    WHEN others then
        Ge_PAmbOnError.Grabarerror(997,   'Excepcion en [<%tableName>.LeerRegistroPorPK]',sqlerrm);
END LeerRegistroPorPK;

-----------------------------------------------
FUNCTION getValueVARCHAR2byPk(pfldName       IN VARCHAR2,
                              <%paramKeyFlds>,
                              pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return VARCHAR2
IS
arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
 wres VARCHAR2(80);
BEGIN
  /*
   GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                                   PPARAMNAME => 'COD_INDDOC_N',
                                   PVALUE => PCOD_INDDOC_N); */
   <%addKeysParametersInvoke>

   wres := GE_PAMBCOMMON.GETVALUEVARCHAR2(pfldName => pFLDNAME,
                                               pTableName => '<%tableName>',
                                               PPARAMS  => ARRPARAMS,
                                               pIndValidaExist => PIND_VALIDAEXISTE);
RETURN wres;
END getValueVARCHAR2byPk;
-----------------------------------------------
FUNCTION getValueNUMBERbyPk(pfldName       IN VARCHAR2,
                            <%paramKeyFlds>,
                            pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return NUMBER
IS
arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
 wres NUMBER;
BEGIN

   <%addKeysParametersInvoke>

   wres := GE_PAMBCOMMON.GETVALUENUMBER(pfldName => pFLDNAME,
                                               pTableName => '<%tableName>',
                                               PPARAMS  => ARRPARAMS,
                                               pIndValidaExist => PIND_VALIDAEXISTE);
RETURN wres;
END getValueNUMBERbyPk;
---------------------------------------------------------------------------------------------
PROCEDURE setValueNUMBERbyPk(pfldName           IN VARCHAR2,
                             <%paramKeyFlds>,
                             pNewVal            IN NUMBER,
                             pCOD_USUARIOREG_V  IN VARCHAR2
) IS

 wexcepcion EXCEPTION;
 wmsg VARCHAR2(500);
 arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
 wCOD_REGISTRO_N <%tableName>.COD_REGISTRO_N%TYPE;
BEGIN
   wCOD_REGISTRO_N :=  getValueNUMBERbyPk(pfldName       => 'COD_REGISTRO_N',
			                                    -- pCOD_INDDOC_N  => pCOD_INDDOC_N
                                          <%paramKeysCall>
                                          );

/*    GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                               PPARAMNAME => 'COD_INDDOC_N',
                               PVALUE => PCOD_INDDOC_N); */

    <%addKeysParametersInvoke>

   GE_PAMBCOMMON.SETVALUENUMBER(pfldName => pFLDNAME,
                pTableName => '<%tableName>',
                PPARAMS  => ARRPARAMS,
                pNewVal => pNewVal);
   -- Codigo del login
   GE_PAMBBITOBJETO.registrar(pcod_accionreg_n     => 3,
                              pdes_tabla           => '<%tableName>',
                              pcod_registro_n      => wCOD_REGISTRO_N,
                              pcod_usuario_v       => pCOD_USUARIOREG_V,
                              pnum_version         => NULL);
EXCEPTION
    WHEN wExcepcion THEN
       Ge_PAmbOnError.Grabarerror(997, wmsg ||  'Excepcion en [<%tableName>.setValueNUMBERbyPk]',sqlerrm);
    WHEN others then
        Ge_PAmbOnError.Grabarerror(997,   'Excepcion en [<%tableName>.setValueNUMBERbyPk]',sqlerrm);
END SetValueNUMBERbyPk;
-----------------------------------------------
FUNCTION getValueDATEbyPk(pfldName       IN VARCHAR2,
                          <%paramKeyFlds>,
                          pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return DATE
IS
arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
 wres DATE;
BEGIN
   /*GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                                   PPARAMNAME => 'COD_INDDOC_N',
                                   PVALUE => PCOD_INDDOC_N); */
    <%addKeysParametersInvoke>

   wres := GE_PAMBCOMMON.GETVALUEDATE(pfldName => pFLDNAME,
                                               pTableName => '<%tableName>',
                                               PPARAMS  => ARRPARAMS,
                                               pIndValidaExist => PIND_VALIDAEXISTE);
RETURN wres;
END getValueDATEbyPk;

-----------------------------------------------
FUNCTION getValueBlobByPk(pfldName       IN VARCHAR2,
                          <%paramKeyFlds>,
                          pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return blob IS
arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
 wres BLOB;
BEGIN
   /* GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                               PPARAMNAME => 'COD_INDDOC_N',
                               PVALUE => PCOD_INDDOC_N); */
   <%addKeysParametersInvoke>
   wres := GE_PAMBCOMMON.GETVALUEBLOB(pfldName => pFLDNAME,
                                       pTableName => '<%tableName>',
                                       PPARAMS  => ARRPARAMS,
                                       pIndValidaExist => PIND_VALIDAEXISTE);
RETURN wres;
END getValueBlobByPk;
-------------------------------------------------------------------------------
/*
   UTILIAR des_pivote para guardar el siguiente mensaje
   Valor anterior : <%valorAnterior>.  Valor Nuevo: <%valorNuevo>
*/
PROCEDURE setValueBloByPk(pfldName           IN VARCHAR2,
                          <%paramKeyFlds>,
                          pNewVal            IN Blob,
                          pCOD_USUARIOREG_V  IN VARCHAR2
) IS
 arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
 wCOD_REGISTRO_N <%tableName>.COD_REGISTRO_N%TYPE;
BEGIN
   wCOD_REGISTRO_N :=  ge_pambdocumento.getValueNUMBERbyPk(pfldName       => 'COD_REGISTRO_N',
                                                           pCOD_INDDOC_N  => pCOD_INDDOC_N);
  <%addKeysParametersInvoke>

  /* GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                                PPARAMNAME => 'COD_INDDOC_N',
                                PVALUE => PCOD_INDDOC_N); */

   GE_PAMBCOMMON.SETVALUEBLOB(pfldName => pFLDNAME,
                                pTableName => '<%tableName>',
                                PPARAMS  => ARRPARAMS,
                                pNewVal => pNewVal);

   -- Codigo del login
   GE_PAMBBITOBJETO.registrar(pcod_accionreg_n     => 3,
                              pdes_tabla           => '<%tableName>',
                              pcod_registro_n      => wCOD_REGISTRO_N,
                              pcod_usuario_v       => pCOD_USUARIOREG_V,
                              pnum_version         => NULL);

END setValueBloByPk;
-----------------------------------------------
FUNCTION getValuesVARCHAR2byPk(plstFieldsSepByComma IN VARCHAR2,
                               <%paramKeyFlds>,
                               pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return ge_pambcommon.arrayVARCHAR2_T

IS
  arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
  wresVector Ge_Pambcommon.arrayVARCHAR2_t;
BEGIN

  <%addKeysParametersInvoke>
  /*
   GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                                   PPARAMNAME => 'COD_INDDOC_N',
                                   PVALUE => PCOD_INDDOC_N); */

   wresVector := GE_PAMBCOMMON.GetValuesVARCHAR2(plstFieldsSepByComma => plstfieldssepbycomma,
                                               pTableName => '<%tableName>',
                                               PPARAMS  => ARRPARAMS,
                                               pIndValidaExist => PIND_VALIDAEXISTE);
RETURN wresVector;
END getValuesVARCHAR2byPk;
-----------------------------------------------
FUNCTION getValuesNUMBERbyPk(plstFieldsSepByComma IN VARCHAR2,
                             <%paramKeyFlds>,
                             pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return ge_pambcommon.arrayNUMBER_T

IS
  arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
  wresVector Ge_Pambcommon.arrayNUMBER_t;
BEGIN
   <%addKeysParametersInvoke>

   /* GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                                   PPARAMNAME => 'COD_INDDOC_N',
                                   PVALUE => PCOD_INDDOC_N); */

   wresVector := GE_PAMBCOMMON.GetValuesNUMBER(plstFieldsSepByComma => plstfieldssepbycomma,
                                               pTableName => '<%tableName>',
                                               PPARAMS  => ARRPARAMS,
                                               pIndValidaExist => PIND_VALIDAEXISTE);
RETURN wresVector;
END getValuesNUMBERbyPk;
-----------------------------------------------
FUNCTION getValuesDATEbyPk(plstFieldsSepByComma IN VARCHAR2,
                           <%paramKeyFlds>,
                           pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return ge_pambcommon.arrayDATE_T

IS
  arrParams GE_PAMBCOMMON.arrayParams_T := GE_PAMBCOMMON.arrayParams_T();
  wresVector Ge_Pambcommon.arrayDATE_t;
BEGIN

  <%addKeysParametersInvoke>
  /*
   GE_PAMBCOMMON.ADDPARAMNUMBER(pParams => arrParams,
                                   PPARAMNAME => 'COD_INDDOC_N',
                                   PVALUE => PCOD_INDDOC_N); */

   wresVector := GE_PAMBCOMMON.GetValuesDATE(plstFieldsSepByComma => plstfieldssepbycomma,
                                               pTableName => '<%tableName>',
                                               PPARAMS  => ARRPARAMS,
                                               pIndValidaExist => PIND_VALIDAEXISTE);
RETURN wresVector;
END getValuesDATEbyPk;
END <%packageName> ;
