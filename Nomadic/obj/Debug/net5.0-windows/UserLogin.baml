   M S B A M L   `   `   `  ����B  >Nomadic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NomadicNomadic  5   	       Nomadic.UserLogin   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Nomadic     5   	   W SFontAwesome5.Net, Version=2.1.4.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5   	   $��Segoe UI Light)�5      $��18(�66     � Title$  Nomadic��5	   	   $	��900��6   $
��1600��6&    � Icon$ /images/nomadic logo.png��63    � ShowInTaskbar$
 True��5
   	   $
{�True��6    � WindowStartupLocation$ CenterScreen=�6/   
���   � � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers	 P� Property
 P� Value   Moon  Button.MouseOver.Background �� Color  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonTemplate �� 
TargetType ��Name J� SnapsToDevicePixels ��Name �� Triggers �� 
TargetName��%?  '��       '�� T    'G� D    &	  4    &	 {    &	 �    &	 �    &	 �    &	     &	 &    &	 I    &	 l    7  7  7  7  7  7  �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � ��$ 2q�60   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��
 �����6+   �� 5       � ��
 �����6,    5      P� 5      	 �@J�IsMouseOver$

 True��61   . �5      ��  � ��
 ��  �63   5      5      �� 5   
   " ��6   .�5      ��  � ��$ 0,0,0,1q�60   �� 5       � ��
 �����6,   �� 5       � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       �@��
CaretBrush
 �����6+   5      �� 5   
   " G�6   .�5       ��  � ��$ 0,0,0,1q�60   �� 5!       � ��
 �����6,   �� 5"       � ��
 ���� 6+   �� 5#       � ��
 �����6+   �� 5$       �@G�
CaretBrush
 �����6+   5%      �� 5&   
   .�5'      ��  � ��$ fonts/#Moon)�67   5(      �� 5)   
   $ 	#FFBEE6FD��6>   �� 5*   
   $ white��6:   �� 5+   
   $ 	#FFC4E5F6��6<   �� 5,   
   $ 	#FF2C628B��68   �� 5-   
   $ 	#FFF4F4F4��6=   �� 5.   
   $ 	#FFADB2B5��69   �� 5/   
   $ 	#FF838383��6=   �� 50   
   " ��61   .R�51      �� $ border��6   #��z��6%   #��z��6O   #��z��6�   $
 true��6�   ._�52      �� $ contentPresenter��6#   $|�False��6=   #��z��6O   #��z��6�   $
��True��6�   # z 6�   #��z��6  53       54      P� 55      	 �@J�IsMouseOver$

 true��61   . �56      �� $ border��63    � ��
 �����6G   �� 57      $ border��64   8    � ��6H   �� 58       � ��
 �   �6?   59      P� 5:      	 � ��$

 true��6/   . �5;      �� $ border��63   8   � ��6G   �� 5<      $ border��64   8   � ��6H   5=      P� 5>      	 � {�$
 false��6/   . �5?      �� $ border��63   8   � ��6G   �� 5@      $ border��64   8   � ��6H   �� 5A      $ contentPresenter��6?   8   � ��6]   5B      5D      5F      .��5H      �  � ColumnDefinitions 5I   
   �� 5J      $��* �6   �� 5K      $	��500 �6   �� 5L      $��* �6   �� 5M      $��* �6   �� 5N      $	��500 �6   �� 5O      $��* �6    � RowDefinitions 5Q   
   �� 5R      $��* �6   �� 5S      $��* �6   �� 5T      $��85 �6   �� 5U      $��85 �6   �� 5V      $��85 �6   �� 5W      $��85 �6   �� 5X      $��85 �6   �� 5Y      $��* �6   �� 5Z      $��* �6   .+�5]   
   �� $��/images/def back.jpg��6   $��9��6.   $��6��6?   $��UniformToFill=�6S    J� Opacity$
 0.50Q�6k   �� 5^   
   $��/images/nomadic logo.png��6   $��1��62   $��3��6B   �� 5_   
   $��NOMADIC��6   $��50(�6#   $��1��61   $��4��6A   $��Center=�6O   
�������$��fonts/#Moon)�6   $��Center=�6�   $��65��6�   $	��246��6�    �� TextAlignment$ Center=�6�   �� 5`   
   $��No account?��6   $��1��6'   $��5��67   
�������$��Center=�6W   $��Center=�6t   $��24(�6�   �� 5a   
   -   5         ��Name$ 	btnSignUp��5a      #���  6$   $��SIGN UP��6h   $��fonts/#Moon)�6z   $��1��6�   $��6��6�   $	��149��6�   $��45��6�   �� 5b   
   -   5        $ 	btnSignIn��5b      #���  6$    �� 	IsDefault$
 True��6P   $��4��6a   $��6��6q   $��LOGIN��6~   $��Center=�6�   $��Center=�6�   $	��120��6�   $��40��6�    5c      ��%    5g      5h        FontAwesome5.ImageAwesome  5i   
      Icon$ Solid_At=�6      
Foreground
 �����$��4��6>   $��4��6N   $��16,35,163,35q�6[    J� RenderTransformOrigin$ 0.555,0.201&�6q     5j   
   $ 
Solid_Lock=�6   
 �����$��4��6@   $��5��6P   $ 0.555,0.201&�6]   $��7,32,162,38q�6�   �� 5k   
   $��
USER LOGIN��6   $
��Wrap=�6&   $��2��6:   $��45(�6G   $��fonts/#Moon)�6U   $��Center=�6n   $��Center=�6�   
�������$��4��6�   $��2��6�   $	��101��6�   $	��192��6�   $ Center=�6�   �� 5l   
   -   5         ��Name$ lblEmail��5l   (   $��Email address��6   $��4��6b   $��4��6o   $
��Left=�6   
�������$��48��6�   $	��Top=�6�   $��184,20,0,10q�6�    �� Target 6:   ��  �� ElementName$ txtEmail��6�   �� 5m   
   -   5         ��Name$ txtEmail��5m      $��4��6`   $��4��6p   $��Center=�6}   $��Center=�6�    �� TextWrapping$ NoWrap=�6�   $	��120��6�   �� 5n   
   -   5        $ lblPassword��5n      $��Password��6%   $��5��6c   $��4��6p   $
��Left=�6�   
�������$��184,20,0,10q�6�    68   �� $ txtPassword��6�   G� 5o   
   -   5          G�Name$  txtPassword��5o      $��4��6m   $��5��6}   $��Center=�6�   $��Center=�6�   $	��120��6�   �� 5p   
   -   5        ! ��Name$! txtError��5p      $��Segoe UI Light)�6&   $�� ��6B   $
��auto��6J   $��24(�6W   $��4��6e   $��7��6u   $��Center=�6�   $��Center=�6�   ���	#FFDE47476�   5r      5s      