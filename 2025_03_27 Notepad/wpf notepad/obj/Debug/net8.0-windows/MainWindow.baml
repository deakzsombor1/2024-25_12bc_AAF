   M S B A M L   `   `   `  ����F  Bwpf notepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:wpf_notepadwpf_notepad  5   	       wpf_notepad.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:wpf_notepad     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    J� InputBindings 5
      �� 5   
    �� Command$ Close��6    �� 	Modifiers$
 Ctrlf�6%   
 �� Key$ q��66   �� 5   
   $
 Ctrlf�64   $ n��6E    6   �� *
NewTabItem+6E    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Save��5      6(     5   
   -   5        $
 Open��5      6(     5   
   -   5        $ Close��5      6)   .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $
��Save��6    m� Command$
 Save��6)   m� 5      $
��Open��6   $
 Open��6)   m� 5      $	��New��6    m� InputGestureText$ Ctrl+N��6(   m� 5      -   5        	 m�Name$	 menuItemExit��5      $
��Exit��61   $ Close��6?   5      5      c� 5   
   $	��Top=�6   .@�5      �� $
��Save��6   $
��Save��6$   �� 5       $
��Open��6   $
��Open��6$   �� 5!      $	��New��6   ��6#   �� *
NewTabItem+5"      �� 5#   
   -   5        
 ��Name$
 
tabcontrol��5#      $��Bottom=�6)   .@�5$      �� -   5        $��new file��5$      .��5%      �� 5&      5'      5(      5)      