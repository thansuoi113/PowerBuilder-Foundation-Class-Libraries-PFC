forward
global type u_tabpg from pfc_u_tabpg
end type
end forward


global type u_tabpg from pfc_u_tabpg 

end type

global u_tabpg u_tabpg

on u_tabpg.create
call pfc_u_tabpg::create
end on

on u_tabpg.destroy
call pfc_u_tabpg::destroy
end on
