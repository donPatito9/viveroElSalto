   M S B A M L   `   `   `  ����F  BElSalto_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ElSalto_GUI.VistasElSalto_GUI.Vistas  5   	   &     ElSalto_GUI.Vistas.AgregarPlanta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ElSalto_GUI.Vistas     5   	     � Title$  AgregarPlanta��5   	   $	��520��6   $	��530��6,   .��5	      � $��	0,0,0,-21q�6   $
��Left=�6   $	��560��69    � RowDefinitions 5
   
   �� 5      $
��223* �6   �� 5      $
��302* �6   .+�5   
   �� -   5         ��Name$ lblNombreComun��5      $��Ingrese Nombre Comun��6(   $
��Left=�6G   $��	62,58,0,0q�6b   $	��Top=�6u    J� RenderTransformOrigin$ 0.516,-0.576&�6�   �� 5   
   -   5        $ lblNombreCientifico��5      $��Ingrese Nombre Cientifico��6-   $
��Left=�6Q   $��	61,94,0,0q�6l   $	��Top=�6   �� 5   
   -   5        $ lblTipoPlanta��5      $��Ingrese Tipo Planta��6'   $
��Left=�6E   $��
60,128,0,0q�6`   $	��Top=�6t   �� 5   
   -   5        $ lblDescripcion��5      $��Ingrese Descripcion��6(   $
��Left=�6F   $��
61,164,0,0q�6a   $	��Top=�6u   �� 5   
   -   5        $ lblTiempoRiego��5      $��Ingrese Tiempo de Riego��6(   $
��Left=�6J   $��
60,198,0,0q�6e   $	��Top=�6y   $��2��6�   �� 5   
   -   5        $ lblCantidadAgua��5      $��Ingrese Cantidad De Agua ��6)   $
��Left=�6M   $��	58,15,0,0q�6h   $	��Top=�6{   $��1��6�   �� 5   
   -   5        $ lblEpoca��5      $��seleccionar Epoca��6"   $
��Left=�6>   $��	61,49,0,0q�6Y   $	��Top=�6l   $��1��6�   �� 5   
   -   5        $ lblEsVenenosa��5      $��seleccionar��6'   $
��Left=�6=   $��	60,94,0,0q�6X   $	��Top=�6k   $��1��6�   �� 5    
   -	   5        $ lblEsAutoctona��5       $��Seleccionar��6(   $
��Left=�6>   $��
60,125,0,0q�6Y   $	��Top=�6m   $��1��6�   �� 5"   
   -
   5         ��Name$ btnAgregarPlanta��5"      $��Agregar Planta��6+   $
��Left=�6D   $��
58,170,0,0q�6_   $	��Top=�6s   $��25��6�   $	��127��6�   $ 0.016,0.402&�6�   $��1��6�   �� 5$   
   -   5         ��Name$ txtNombreComun��5$      $
��Left=�6*   $��
320,61,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $ 	0.5,1.283&�6�   �� 5&   
   -   5        $ txtNombreCientifico��5&      $
��Left=�60   $��
320,96,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5(   
   -   5         ��Name$ cmbTipoPlanta��5(      $
��Left=�6*   $��320,132,0,0q�6E   $	��Top=�6Z   $	��120��6r   .@�5)      �� $	��120��6   �� 5*      $��Seleccionar��6    �� 
IsSelected . {�. 6C   �� 5+      $��Herbacea��6   �� 5,      $��Matorral��6   �� 5-      $��Arbusto��6   �� 5.      $��Arbol��6   5/      �� 50   
   -   5        $ txtDescripcion��50      $
��Left=�6*   $��320,171,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   �� 52   
   -   5        $ txtTiempoRiego��52      $
��Left=�6*   $��320,206,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��2��6�   �� 54   
   -   5        $ txtCantidadAgua��54      $
��Left=�6+   $��
320,20,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��1��6�   �� 56   
   -   5        $ cmbEpoca��56      $
��Left=�6%   $��
320,53,0,0q�6@   $	��Top=�6T   $	��120��6l   $��1��6�   .@�57      �� $	��120��6   �� 58      $��Verano��6    . {�. 6>   �� 59      $��Invierno��6   �� 5:      $��	Primavera��6   �� 5;      $��Otoño��6   5<      �� 5>   
   -   5        	 ��Name$	 chkEsVenenosa��5>      $��Es Venenosa ?��6*   $
��Left=�6B   $��320,100,0,0q�6]   $	��Top=�6r   $	��125��6�   $��20��6�   $��1��6�   �� 5@   
   -   5        $	 chkEsAutoctona��5@      $��Es Autoctona ?��6+   $
��Left=�6D   $��320,135,0,0q�6_   $	��Top=�6t   $	��100��6�   $��20��6�   $��1��6�   5B      5C      