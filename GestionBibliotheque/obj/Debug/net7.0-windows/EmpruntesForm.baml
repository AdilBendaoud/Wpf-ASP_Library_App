   M S B A M L   `   `   `  ����N  JGestionBibliotheque, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:GestionBibliothequeGestionBibliotheque  5   	   '    !GestionBibliotheque.EmpruntesForm   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:GestionBibliotheque     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   -   5          � WindowStyle$
  None=�5   9    � Title$ EmpruntesForm��5	   	   $	��600��6   $	��500��6,   '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      CaptionHeight$ 0Q�6      CornerRadius$ 0��6)      GlassFrameThickness$ 0q�6:   .��5      �� $��5q�6   ���#2c2c2c._�5   
   ]� .+�5      ]� $��False��6   $	��Top=�6.   ���#2c2c2c$��30��6X   .+�5      �� $
��Left=�6    �� Orientation$ 
Horizontal=�68   .+�5      �� $��20��6   $��20��6'   $	��5 0q�63   $[��UC:\Users\pc\source\repos\GestionBibliotheque\GestionBibliotheque\Assets\lightlogo.png��6@   �� 5      $��Center=�6    $��SemiBold"�6;   
�������" BiblioSphère - Ajouter un Livre6�   5      �� 5      $ 
Horizontal=�6   $��Right=�66   $��Center=�6M   .+�5      �� -   5         � Cursor$
 Hand��5   1   $��30��6@   $��20��6K   
������ $��0q�6p   .��5      "  FontAwesome.WPF.ImageAwesome     Icon$ WindowMinimize=�6*   $��14��6@   	   
Foreground
	 �����6K   ��5      �� 5      
 �� 
TargetType"
 ��6$   .�5   "   ��  �� Property � �� �� Value
 ���� 6?    �� Triggers 5   "   P� 5   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5   *   ��  � �� �#3d3d3d6G   5   '   5      5!      �� 5"      -   5        $
 Hand��5"   1   $��30��6?   $��20��6J   
������ $��0q�6o   .��5#        $ WindowMaximize=�6*   $��14��6@   
	 �����6K   ��5$      �� 5%      "
 ��6$   .�5&   "   ��  � ��
 ���� 6?    5'   "   P� 5(   &    �@J�IsMouseOver$
 True��6E   . �5)   *   ��  � �� �#3d3d3d6G   5*   '   5,      5.      �� 5/      -   5        $��30��5/   *   $��20��65      	DangerBtn#���   6A   .��50        $ Times=�6*   $��14��67   
	 �����6B   51      52      53      � 54      $��50 35q�6    � RowDefinitions 55      �� 56      6&   �� 57      6&   �� 58      6&   �� 59      6&   �� 5:      6&   �� 5;      6&   �� 5<      6&   .+�5?      �� $��0��6   .+�5@      �� $��5q�6   $��14(�6(   $��Titre :��66   �� 5A      -   5         ��Name$ 
titreInput��5A       �� 
IsReadOnly$
 True��62   $��5q�6D   $��25��6O   5B      �� 5D      $��1��6   .+�5E      �� $��CIN :��6   $��14(�6,   �� 5F      -   5        $ CINInput��5F      $
 True��60   $��5q�6B   $��25��6M   5G      �� 5I      $��2��6   .+�5J      �� $��14(�6   $��Nom et Prenom :��6*   �� 5K      -   5        $ NomInput��5K      $
 True��60   $��5q�6B   $��25��6M   5L      �� 5N      $��3��6   .+�5O      �� $��14(�6   $��Date d'emprunt :��6*   (  "System.Windows.Controls.DatePicker  5P      -   5          Name$ dateEmpruntInput��5P   !   5Q      �� 5S      $��4��6   .+�5T      �� $��14(�6   $��Date retour prevue :��6*     5U      -	   5        $ dateEmprunPrevuetInput��5U   !   5V      �� 5X      $��Center=�6   $ 
Horizontal=�68   $��5��6Q   .+�5Y      �� $��14(�6   $��10q�6*   $��Enregistrer le retour :��66   �� 5Z      -
   5         ��Name$ retourCheckBox��5Z       � LayoutTransform 5[      �� 5\       �� ScaleX$	 1.5Q�6-    �� ScaleY$	 1.5Q�6:   5^      �� 5_      -   5        $ 	prixInput��5_      $��	40 0 10 0q�61   $	��100��6D   $��25��6P   �� 5`      $��Center=�6    $��16(�6;   $��SemiBold"�6I   DH6c   5a      �� 5b      -   5        $ idInput��5b      $y�	Collapsed=�6+   �� 5c      -   5         ��Name$ 	updateBtn��5d        
primaryBtn#���  5e      $��6��6:   $��Center=�5f   .   $	��120��6K   $��35��6W   $��Bottom=�5g      $��
0,10,10,10q�60   .��5h      �� $ 
Horizontal=�6!   .+�5i        
	 �����$ FloppyOutline=�6=   $��18��6R   $��0 0 5 0q�6]   �� 5j      
Sauvgarder60   5k      5l      5m      5n      5o      5p      