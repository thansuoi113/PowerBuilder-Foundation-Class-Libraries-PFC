forward
global type w_statusbar from pfc_w_statusbar
end type
end forward


global type w_statusbar from pfc_w_statusbar 

end type

global w_statusbar w_statusbar

on w_statusbar.create
call pfc_w_statusbar::create
end on

on w_statusbar.destroy
call pfc_w_statusbar::destroy
end on
