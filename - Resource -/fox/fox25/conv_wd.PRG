para f1,l1

l1=l1+1
f1= ltrim(f1)
f1_old=f1
***************ffffff-------------------------
f1=strt(f1,'�',' ')
z2='�()x����������0123456789/��0������ �  � � � � � � � � � �  � � � � � � � � � � � � � � �  � � �_�����������������왬����������  �'
z1='�)(*01234567890123456789/��0������ �  � � � � � � � � � �  � � � � � � � � � � � � � � �  � � �܍����������������������������  �'
f1= FSISW(chrt(f1,z1,z2))
f1= ltrim(f1)
*f1= STRTRAN(f1, '�', '��', 1)
f1=strt(f1,'  ',' ')



f1=ch2(f1_old,"�","�","�",f1)


f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)
f1=ch1(f1_old,"�","�","�",f1)



f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)
f1=ch2(f1_old,"�","�","�",f1)


return (f1)


func ch1
para f_1,chr_1,chr_2,chr_3,f_new
F_NEW=F_NEW+' '
for i_i=2 to len(f_NEW)

	if subs((f_new),i_i,1)=chr_1 .and. subs(f_new,i_i-1,1)#" "
		f_new=subs(f_new,1,i_i-1)+iif((subs(f_new,i_i+1,1)#" " .AND. subs(f_new,i_i+1,1)#"�"),chr_2,chr_3)+subs(f_new,i_i+1,40)
	endif
next i_i
retur f_new


func ch2
para f_1,chr_1,chr_2,chr_3,f_new
F_NEW=F_NEW+' '
*U_1="�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�"
for i_i=2 to len(f_NEW)
	if subs((f_new),i_i,1)=chr_1 
		f_new=subs(f_new,1,i_i-1)+iif((subs(f_new,i_i-1,1)#" " .AND.;
		inlist(subs(f_new,i_i+1,1),"�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�","�"));
		,chr_2,chr_1)+subs(f_new,i_i+1,40)
		f_new=subs(f_new,1,i_i-1)+iif((subs(f_new,i_i-1,1)#" " .AND.;
		inlist(subs(f_new,i_i+1,1),"�","�","�","�","�","�","�","�"," ","�","�","�","�",")","("));
		,chr_2,chr_1)+subs(f_new,i_i+1,40)

	endif
next i_i
retur f_new


*����������������

*ԝ�ԝ�ԝ�ԝ�ԝ�