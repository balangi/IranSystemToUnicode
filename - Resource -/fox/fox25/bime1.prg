set talk off
set echo off
set decimals to 0
close databases
SET DEFAULT TO 'D:\FOX'

f1 = 'H3053R.TXT'
f2 = 'H3054R.TXT'
if not file(f1)
	@10,10 say 'error1: ' + f1 + ' not found!'
	return
endif
if not file(f2)
	@10,10 say 'error2: ' + f2 + ' not found!'
	return
endif
if not file('dskwor00.dbf')
	@10,10 say 'error3: dskwor00.dbf not found!'
	return
endif
if not file('dskkar00.dbf')
	@10,10 say 'error4: dskkar00.dbf not found!'
	return
endif
use dskwor00 exclusive
delete all
pack
append from &f1  TYPE DELIMITED WITH TAB


use dskkar00 exclusive
delete all
pack
append from &f2  TYPE DELIMITED WITH TAB
!VEGAF
use dskwor00 exclusive
repl all dsw_fname with ltrim(conv_wd(dsw_fname,100))
repl all dsw_lname with ltrim(conv_wd(dsw_lname,100))
repl all dsw_dname with ltrim(conv_wd(dsw_dname,100))
repl all dsw_idplc with ltrim(conv_wd(dsw_idplc,100))
repl all dsw_sex with ltrim(conv_wd(dsw_sex,100))
repl all dsw_nat with ltrim(conv_wd(dsw_nat,100))
repl all dsw_ocp with ltrim(conv_wd(dsw_ocp,100))


use dskkar00 exclusive
repl all dsk_name with ltrim(conv_wd(dsk_name,100))
repl all dsk_farm with ltrim(conv_wd(dsk_farm,100))
repl all dsk_adrs with ltrim(conv_wd(dsk_adrs,100))
repl all dsk_disc with ltrim(conv_wd(dsk_disc,100))

@10,10 say 'File creation completed!'
QUIT