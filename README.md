# GestureControls
扩展WinForm基础控件用以支持Gesture，在Windows 7（配备触控屏或者手写板）中有效。

GesturePanel，在Panel启动滚动后，如果有手势操作则滑动，并且禁用WM_VSCROLL消息。
不禁用WM_VSCROLL会造成这样一种情形，手势操作在移动滚动区域，WM_VSCROLL也在移动滚动区域，此时会导致滚动区域闪烁。

GestureUserControl，主要公开一个Gesture事件，用户可以添加自定义处理程序。
因为在Win7触摸屏上使用手势滑动时，Panel窗口中不包含子控件的区域可以接收WM_VSCROLL消息，但是子控件本身不会处理WM_VSCROLL消息，
所以导致在子控件上使用手势时，父Panel不会滑动。
