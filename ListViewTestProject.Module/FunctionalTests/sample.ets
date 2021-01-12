;#DropDB ListViewTestProjectEasyTest

#Application ListViewTestProjectWin
#Application ListViewTestProjectWeb
#IfDef ListViewTestProjectWin

*Action About...
 
*Action OK

#EndIf

#IfDef ListViewTestProjectWeb
!Action Navigation(My Details)
#EndIf
