para f1,l1

l1=l1+1
f1= ltrim(f1)
f1_old=f1
***************ffffff-------------------------
f1=strt(f1,'',' ')
z2='()x€‚ƒ„…†‡ˆ‰0123456789/–§0üùô‘’ ”  ˜ š œ    ¢ £ ò ¤ ¥  © « ­ ¯ à á å é ë í ï ñ õ ö ø  ı  ¦_•ûğîìêèäü›Ÿ¡úãçêì™¬®÷—ó“ş¨ªâæ  ‘'
z1='Á)(*01234567890123456789/ÊÓ0íåÂãÇÈ   Ë Ì  Í Î Ï Ğ ª Ñ Ò  Ô Õ Ö Ø Ù Ú Û İ Ş ß  á ã ä æ  í Ç ÜåßŞİÛÚíÌÍÎåÚÛİŞËÕÖäÊáÈíÓÔÆÚ  Ã'
f1= FSISW(chrt(f1,z1,z2))
f1= ltrim(f1)
*f1= STRTRAN(f1, 'ª', 'áÇ', 1)
f1=strt(f1,'  ',' ')



f1=ch2(f1_old,"Á","","",f1)


f1=ch1(f1_old,"â","ã","ä",f1)
f1=ch1(f1_old,"á","ã","ä",f1)
f1=ch1(f1_old,"ù","ú","û",f1)
f1=ch1(f1_old,"å","ç","è",f1)
f1=ch1(f1_old,"ë","ì","ì",f1)
f1=ch1(f1_old,"ô","õ","õ",f1)
f1=ch1(f1_old,"ü","ş","ş",f1)
f1=ch1(f1_old,"œ","","",f1)
f1=ch1(f1_old," ","¡","¡",f1)
f1=ch1(f1_old,"š","›","›",f1)
f1=ch1(f1_old,"”","•","•",f1)
f1=ch1(f1_old,"–","—","—",f1)
f1=ch1(f1_old,"’","“","“",f1)
f1=ch1(f1_old,"§","¨","¨",f1)
f1=ch1(f1_old,"","Ÿ","Ÿ",f1)
f1=ch1(f1_old,"«","¬","¬",f1)
f1=ch1(f1_old,"­","®","®",f1)
f1=ch1(f1_old,"©","ª","ª",f1)
f1=ch1(f1_old,"ö","÷","÷",f1)
f1=ch1(f1_old,"ñ","ó","ó",f1)
f1=ch1(f1_old,"é","ê","ê",f1)
f1=ch1(f1_old,"ï","ğ","ğ",f1)
f1=ch1(f1_old,"í","î","î",f1)



f1=ch2(f1_old,"‘","","",f1)
f1=ch2(f1_old,"â","ã","ä",f1)
f1=ch2(f1_old,"á","ã","ä",f1)
f1=ch2(f1_old,"ã","ä","ä",f1)
f1=ch2(f1_old,"ù","ú","û",f1)
f1=ch2(f1_old,"ú","û","û",f1)
f1=ch2(f1_old,"å","ç","è",f1)
f1=ch2(f1_old,"ç","è","è",f1)
f1=ch2(f1_old,"ë","ì","ì",f1)
f1=ch2(f1_old,"ô","õ","õ",f1)
f1=ch2(f1_old,"ü","ş","ş",f1)
f1=ch2(f1_old,"œ","","",f1)
f1=ch2(f1_old," ","¡","¡",f1)
f1=ch2(f1_old,"š","›","›",f1)
f1=ch2(f1_old,"”","•","•",f1)
f1=ch2(f1_old,"–","—","—",f1)
f1=ch2(f1_old,"’","“","“",f1)
f1=ch2(f1_old,"§","¨","¨",f1)
f1=ch2(f1_old,"","Ÿ","Ÿ",f1)
f1=ch2(f1_old,"«","¬","¬",f1)
f1=ch2(f1_old,"­","®","®",f1)
f1=ch2(f1_old,"©","ª","ª",f1)
f1=ch2(f1_old,"ö","÷","÷",f1)
f1=ch2(f1_old,"ñ","ó","ó",f1)
f1=ch2(f1_old,"é","ê","ê",f1)
f1=ch2(f1_old,"ï","ğ","ğ",f1)
f1=ch2(f1_old,"í","î","î",f1)


return (f1)


func ch1
para f_1,chr_1,chr_2,chr_3,f_new
F_NEW=F_NEW+' '
for i_i=2 to len(f_NEW)

	if subs((f_new),i_i,1)=chr_1 .and. subs(f_new,i_i-1,1)#" "
		f_new=subs(f_new,1,i_i-1)+iif((subs(f_new,i_i+1,1)#" " .AND. subs(f_new,i_i+1,1)#"‘"),chr_2,chr_3)+subs(f_new,i_i+1,40)
	endif
next i_i
retur f_new


func ch2
para f_1,chr_1,chr_2,chr_3,f_new
F_NEW=F_NEW+' '
*U_1="‘","ï","í","ô","ö","–","ñ","”","’","ı","ü","§","©","œ","š",""," ","ù","â","á","æ","å","é","ë","˜","«","­"
for i_i=2 to len(f_NEW)
	if subs((f_new),i_i,1)=chr_1 
		f_new=subs(f_new,1,i_i-1)+iif((subs(f_new,i_i-1,1)#" " .AND.;
		inlist(subs(f_new,i_i+1,1),"‘","ï","í","ô","ö","–","ñ","’","ı","ü","§","©","œ","š",""," ","ù"));
		,chr_2,chr_1)+subs(f_new,i_i+1,40)
		f_new=subs(f_new,1,i_i-1)+iif((subs(f_new,i_i-1,1)#" " .AND.;
		inlist(subs(f_new,i_i+1,1),"","¢","á","å","é","ë","«","­"," ","¤","¥","ø","¦",")","("));
		,chr_2,chr_1)+subs(f_new,i_i+1,40)

	endif
next i_i
retur f_new


*ÃÃÃÃÃÃÃÃÃÃÃÃÃÃÃÃ

*ÔäÔäÔäÔäÔä