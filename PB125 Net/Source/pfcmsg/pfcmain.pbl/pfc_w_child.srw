forward
global type pfc_w_child from w_master
end type
end forward


global type pfc_w_child from w_master 

end type

global pfc_w_child pfc_w_child

on pfc_w_child.create
call w_master::create
end on

on pfc_w_child.destroy
call w_master::destroy
end on
