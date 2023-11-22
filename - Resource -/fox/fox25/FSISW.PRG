proc fsisw
PARAMETER STR___RTS
PRIVATE I_______I , J_______J , OSTR_RTSO
SET TALK OFF
SET ESCAPE OFF
I_______I = 1
k_______k = 0
J_______J = LEN(STR___RTS)+1
OSTR_RTSO = SPACE(J_______J-1)
DO WHILE I_______I<J_______J

   if asc(SUBSTR(STR___RTS,J_______J-I_______I,1))<47 .or. asc(SUBSTR(STR___RTS,J_______J-I_______I,1))>57 .or. I_______I>j_______j
      if k_______k > 0
         OSTR_RTSO = STUFF(OSTR_RTSO,I_______I-k_______k,k_______k,SUBSTR(STR___RTS,J_______J-m_______m-k_______k,k_______k))
         k_______k = 0
*      set step on
      endif
      OSTR_RTSO = STUFF(OSTR_RTSO,I_______I,1,SUBSTR(STR___RTS,J_______J-I_______I,1))
   else
      if k_______k = 0
      m_______m = I_______I-1
      endif
      k_______k = k_______k+1
   endif
   I_______I = I_______I+1
ENDDO
      if k_______k > 0
         OSTR_RTSO = STUFF(OSTR_RTSO,I_______I-k_______k,k_______k,SUBSTR(STR___RTS,J_______J-m_______m-k_______k,k_______k))
      endif
RETURN (OSTR_RTSO)
