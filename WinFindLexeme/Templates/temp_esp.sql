create or replace PACKAGE <%packageName> IS
-- Funcion para determinar que un registro existe tabla GE_AMBDOCUMENTO
FUNCTION EXISTE (<%paramKeyFlds>) RETURN NUMBER;
-- Consecutivo para la Tabla  GE_AMBDOCUMENTO
----------------------------------------------------------------
FUNCTION CONSECUTIVO  RETURN NUMBER;
----------------------------------------------------------------
-- Procedimiento de insercion en la tabla GE_AMBDOCUMENTO
PROCEDURE INSERTA (<%insertParams>,
                   pFEC_INGRESO       IN DATE     DEFAULT SYSDATE,
                   pCOD_USUARIOREG_V  IN VARCHAR2
);
---------------------------------------------------------------

-- Procedimiento de modificacion en la tabla GE_AMBDOCUMENTO
PROCEDURE MODIFICA (<%modifyParams>
                    pCOD_USUARIOREG_V IN VARCHAR2,
                    pCOD_REGISTRO_N IN NUMBER,
                    PNUM_VERSION IN NUMBER
);
----------------------------------------------------------------
-- Procedimiento de Borrado en la tabla GE_AMBDOCUMENTO
PROCEDURE BORRA (<%paramKeyFlds>
                  pCOD_USUARIOREG_V IN VARCHAR2,
                  pCOD_REGISTRO_N IN NUMBER);
 ----------------------------------------------------------------

-- Procedimiento para cambiar de estado en la GE_AMBDOCUMENTO
PROCEDURE CAMBIA_ESTADO (<%paramKeyFlds>,
           pCOD_ESTADO_N IN NUMBER,
           pCOD_USUARIOREG_V IN VARCHAR2,
           pCOD_REGISTRO_N IN NUMBER,
           PNUM_VERSION IN NUMBER);

----------------------------------------------------------------
-- Procedimiento que lee tabla por primary key.
-- Retorna un registro de tipo documento
FUNCTION LeerRegistroPorPK (<%paramKeyFlds>,
                            pBlockReg       IN BOOLEAN DEFAULT FALSE,
                            pIndValidaExist IN VARCHAR2 DEFAULT 'S'
) RETURN GE_AMBDOCUMENTO%ROWTYPE;
-----------------------------------------------
FUNCTION getValueVARCHAR2byPk(pfldName       IN VARCHAR2,
                            <%paramKeyFlds>,
                            pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return VARCHAR2;
-----------------------------------------------
FUNCTION getValueNUMBERbyPk(pfldName       IN VARCHAR2,
                            <%paramKeyFlds>,
                            pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return NUMBER;
-----------------------------------------------
PROCEDURE setValueNUMBERbyPk(pfldName           IN VARCHAR2,
                             <%paramKeyFlds>,
                             pNewVal            IN NUMBER,
                             pCOD_USUARIOREG_V  IN VARCHAR2
);
-----------------------------------------------
FUNCTION getValueDATEbyPk(pfldName       IN VARCHAR2,
                          <%paramKeyFlds>,
                          pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return DATE;
-----------------------------------------------
FUNCTION getValueBlobByPk(pfldName       IN VARCHAR2,
                          <%paramKeyFlds>,
                          pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return blob;
PROCEDURE setValueBloByPk(pfldName           IN VARCHAR2,
                          <%paramKeyFlds>,
                          pNewVal            IN Blob,
                          pCOD_USUARIOREG_V  IN VARCHAR2
);
-----------------------------------------------
FUNCTION getValuesVARCHAR2byPk(plstFieldsSepByComma IN VARCHAR2,
                               <%paramKeyFlds>,
                               pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return ge_pambcommon.arrayVARCHAR2_T
;
-----------------------------------------------
FUNCTION getValuesNUMBERbyPk(plstFieldsSepByComma IN VARCHAR2,
                             <%paramKeyFlds>,
                             pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return ge_pambcommon.arrayNUMBER_T
;
-----------------------------------------------
FUNCTION getValuesDATEbyPk(plstFieldsSepByComma IN VARCHAR2,
                           <%paramKeyFlds>,
                           pInd_ValidaExiste IN VARCHAR2 Default 'S'
) return ge_pambcommon.arrayDATE_T
;
----------------------------------------------------------------
END <%packageName>;
