forward
global type u_pbarproperties from u_tab
end type
type tabpage_1 from u_pbargeneral within u_pbarproperties
end type
type tabpage_2 from u_pbarfont within u_pbarproperties
end type
type tabpage_3 from u_pbarposition within u_pbarproperties
end type
end forward


global type u_pbarproperties from u_tab 

tabpage_1 tabpage_1 
tabpage_2 tabpage_2 
tabpage_3 tabpage_3 
end type


global u_pbarproperties u_pbarproperties

type variables

end variables

on u_pbarproperties.create
this.tabpage_1=create tabpage_1
this.tabpage_2=create tabpage_2
this.tabpage_3=create tabpage_3
int iCurrent
call super::create
iCurrent=UpperBound(this.Control)
this.Control[iCurrent+1]=tabpage_1
this.Control[iCurrent+2]=tabpage_2
this.Control[iCurrent+3]=tabpage_3
end on

on u_pbarproperties.destroy
call super::destroy
destroy(this.tabpage_1)
destroy(this.tabpage_2)
destroy(this.tabpage_3)
end on

type tabpage_1 from u_pbargeneral within u_pbarproperties 

end type



type tabpage_2 from u_pbarfont within u_pbarproperties 

end type



type tabpage_3 from u_pbarposition within u_pbarproperties 

end type

