   M S B A M L   `   `   `  ����K  Glab3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=05fdf4027f7b1445clr-namespace:lab3lab3  5   	       lab3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:lab3     5   	     � Title$  ShapeEditor��5   	   $	��382��6   $��668.137��6*   .��5	      � -   5        $��0,0,0,0q�5	       � RowDefinitions 5
   
   �� 5      .+�5   
   �� -   5        $��shapeViewBox��5      $
��Left=�6&   $	��252��6A   $��	19,36,0,0q�6N   $	��Top=�6a   $	��207��6y   �� 5   
   -   5        $��shapesGroupBox��5      $
��Left=�6+   $	��190��6F   $��
242,36,0,0q�6S   $	��Top=�6g   $	��182��6   �� 5   
   -   5        $��SaveFileButton��5      $
��Save��6'   $
��Left=�66   $��25��6Q   $��297,263,0,0q�6]   $	��Top=�6r   $��80��6�   6�   �� 5   
   -   5        $��LoadFileButton��5      $
��Load��6'   $
��Left=�66   $��25��6Q   $��297,293,0,0q�6]   $	��Top=�6r   $��80��6�   6�   �� 5   
   -   5        $��
EditButton��5      $
��Edit��6#   $
��Left=�62   $��25��6M   $��
19,293,0,0q�6Y   $	��Top=�6m   $��98��6�   6�   �� 5   
   -   5        $��DeleteButton��5      $��Delete��6%   $
��Left=�66   $��25��6Q   $��128,293,0,0q�6]   $	��Top=�6r   $��98��6�   6�   �� 5   
   -   5        $��ShapeProperties��5      $��465,70,10,10q�6,   $y�Hidden=�6B   �� 5   
   -	   5        $��
Properties��5      $��
Properties��6"   $��481,24,90,286q�67   	� 5   
   -
   5        $��ArchivationRadioButton��5      $��Archivation��64   $
��Left=�6J   $��325,226,0,0q�6e   $	��Top=�6z   $��90��6�   	� 5   
   -   5        $��EncryptionRadioButton��5      $��
Encryption��63   $
��Left=�6H   $��325,243,0,0q�6c   $	��Top=�6x   $��90��6�   �� 5   
   -   5        $��WriteToFileMethod��5      $
��Left=�6.   $��32��6I   $��258,226,0,0q�6U   $	��Top=�6j   $��62��6�   .+�5      	� -   5        $$��BinarySerializationRadioButton��5      $��Binary��6@   $
��Left=�6Q   $	��Top=�6l   $��59��6�   	� 5      -   5        $"��TextSerializationRadioButton��5      $
��Text��6>   $
��Left=�6M   $	��Top=�6h   $��59��6�   $��14��6�   5      5      5      