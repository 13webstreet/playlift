   M S B A M L   `   `   `  ����  TRMAwsS3TransferUtility.    (TRMAwsS3TransferUtility.S3TransferWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$'  !Amazon S3 Transfer Utility Sample��5      $	��426��6/   $	��700��6<    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 70��6&   �� 5       � ��$ 25��6'   �� 5	       � ��$ 5,0,0,0q�6'   5
      5      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��.5* �6   �� 5      $��1* �6   �� 5      $
��1.5* �6   .+�5   
   � $��0��6   $��0��6   .+�5      �� $��10, 10, 10, 10q�6   
����ح� �� RadiusX$ 10��6A    �� RadiusY$ 10��6N   � 5      $��20, 20, 20, 20q�6    5      �� 5      $
��auto �6'   �� 5      $��2* �6'   .+�5      �� $��0��6   $��Center=�6,   $
��Left=�6G   	Bucket:6l   �� 5       $��1��6   $��Center=�6B   $��Stretch=�6]   $��
5, 0, 5, 0q�6{   ��6*   �� *Bucket+6�   5!      5"      � 5#   
   $��0��6   $��1��6   .+�5$      �� $��10, 10, 10, 10q�6   
����ح�$ 10��6A   $ 10��6N   � 5%      $��20, 20, 20, 20q�6    5&      �� 5'       5)      �� 5*      $��1* �6$   �� 5+      $
��1.5* �6$   �� 5,      $��1* �6$   .+�5/      ]� $��0��6   $��0��6)   .+�50      �� $��Center=�6    $
��Left=�6;   Choose File:6_   �� 51      -   5        $��Right=�51      .��6I   Upload6Q   �� 52      -   5        $��Right=�52      .��6M   Browse6U   �� 53      -   5        $��_ctlUploadFile��53      $��Center=�6P   $��Stretch=�6k   $��
5, 0, 5, 0q�6�   ��64   �� *
UploadFile+6�   54      � 55      -   5        $��_ctlFileProgressBar��55   �   $��1��6   $��0��6+   $	��Top=�6;   $��Stretch=�6P   $��30��6n   $��10, 10, 10, 10q�6}   6�   �� 56      -   5        $��_ctlFileTransferLabel��56   Q   $��2��6   $��0��6)   $��Bottom=�69   $��30��6n   0 / 0 Bytes6�   57      58      � 59   
   $��0��6   $��2��6   .+�5:      �� $��10, 10, 10, 10q�6   
����ح�$ 10��6A   $ 10��6N   � 5<      $��20, 20, 20, 20q�6    5=      �� 5>       5@      �� 5A      $��1* �6$   �� 5B      $
��1.5* �6$   �� 5C      $��1* �6$   �� 5D      $
��1.5* �6$   �� 5E      $��1* �6$   .+�5H      ]� $��0��6   $��0��6)   .+�5I      �� $��Center=�6    $
��Left=�6;   Choose Directory:6d   �� 5J      -   5        $��Right=�5J      .��6R   Upload6Z   �� 5K      -   5        $��Right=�5K      .��6R   Browse6Z   �� 5L      -   5        $��_ctlUploadDirectory��5L      $��Center=�6Z   $��Stretch=�6u   $��
5, 0, 5, 0q�6�   ��69   �� *UploadDirectory+6�   5M      � 5N      -	   5        $"��_ctlDirectoryFileProgressBar��5N   �   $��1��6   $��Stretch=�6+   $	��Top=�6I   $��30��6a   $��10, 10, 10, 10q�6p   6�   �� 5O      -
   5        $��_ctlNumberOfFilesLabel��5O   Q   $��2��6   $��0��6)   $��Bottom=�69   $��30��6o   0 / 0 Files6�   � 5P      -   5        $)��#_ctlDirectoryCurrentFileProgressBar��5P   �   $��3��6   $��Stretch=�6+   $	��Top=�6I   $��30��6a   $��10, 10, 10, 10q�6p   6�   �� 5Q      -   5        $#��_ctlCurrentFilesTransferLabel��5Q   Q   $��4��6   $��0��6)   $��Bottom=�69   $��30��6v   0 / 0 Bytes6�   5R      5S      5U      5V      