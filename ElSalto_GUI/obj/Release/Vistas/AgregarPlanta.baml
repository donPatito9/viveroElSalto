   M S B A M L   `   `   `  ���� F  BElSalto_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ElSalto_GUI.VistasElSalto_GUI.Vistas  &     ElSalto_GUI.Vistas.AgregarPlanta   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:ElSalto_GUI.Vistas       � Title$  AgregarPlanta��$	��520��$	��530��.��� $��	0,0,0,-21q�$
��Left=�$	��560�� � RowDefinitions �� $
��223* ��� $
��302* �.+��� -    ��Name$ lblNombreComun��$��Ingrese Nombre Comun��$
��Left=�$��	62,58,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.516,-0.576&��� -   $ lblNombreCientifico��$��Ingrese Nombre Cientifico��$
��Left=�$��	61,94,0,0q�$	��Top=��� -   $ lblTipoPlanta��$��Ingrese Tipo Planta��$
��Left=�$��
60,128,0,0q�$	��Top=��� -   $ lblDescripcion��$��Ingrese Descripcion��$
��Left=�$��
61,164,0,0q�$	��Top=��� -   $ lblTiempoRiego��$��Ingrese Tiempo de Riego��$
��Left=�$��
60,198,0,0q�$	��Top=�$��2���� -   $ lblCantidadAgua��$��Ingrese Cantidad De Agua ��$
��Left=�$��	58,15,0,0q�$	��Top=�$��1���� -   $ lblEpoca��$��seleccionar Epoca��$
��Left=�$��	61,49,0,0q�$	��Top=�$��1���� -   $ lblEsVenenosa��$��seleccionar��$
��Left=�$��	60,94,0,0q�$	��Top=�$��1���� -	   $ lblEsAutoctona��$��Seleccionar��$
��Left=�$��
60,125,0,0q�$	��Top=�$��1���� -
    ��Name$ btnAgregarPlanta��$��Agregar Planta��$
��Left=�$��
58,170,0,0q�$	��Top=�$��25��$	��127��$ 0.016,0.402&�$��1���� -    ��Name$ txtNombreComun��$
��Left=�$��
320,61,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$ 	0.5,1.283&��� -   $ txtNombreCientifico��$
��Left=�$��
320,96,0,0q�$
 Wrap=�$	��Top=�$	��120���� -    ��Name$ cmbTipoPlanta��$
��Left=�$��320,132,0,0q�$	��Top=�$	��120��.@��� $	��120���� $��Seleccionar�� �� 
IsSelected . {�. �� $��Herbacea���� $��Matorral���� $��Arbusto���� $��Arbol���� -   $ txtDescripcion��$
��Left=�$��320,171,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $ txtTiempoRiego��$
��Left=�$��320,206,0,0q�$
 Wrap=�$	��Top=�$	��120��$��2���� -   $ txtCantidadAgua��$
��Left=�$��
320,20,0,0q�$
 Wrap=�$	��Top=�$	��120��$��1���� -   $ cmbEpoca��$
��Left=�$��
320,53,0,0q�$	��Top=�$	��120��$��1��.@��� $	��120���� $��Verano�� . {�. �� $��Invierno���� $��	Primavera���� $��Otoño���� -   	 ��Name$	 chkEsVenenosa��$��Es Venenosa ?��$
��Left=�$��320,100,0,0q�$	��Top=�$	��125��$��20��$��1���� -   $	 chkEsAutoctona��$��Es Autoctona ?��$
��Left=�$��320,135,0,0q�$	��Top=�$	��100��$��20��$��1��