Automated Marking Application (Version 1.0) 


This application processes template/forms by applying several filters to them and marks the forms by 
comparing the positional information of each rectangular object (blob) in the it to the corresponding blob in the template.
Please note that it is important to have acquired the digital image files of the examination sheets before the application is used.
The application does not provide this functionality and this can be done using Microsoft Paint software or a scanner. These files 
must be saved in any of these application supported file formats-(BMP (.bmp), JPEG (.jpg), PNG (.png), GIF (.gif) and TIFF (.tiff)). 
The application starts with the first blob in the form, and compares the location of the selected blob to the corresponding blob 
in the template. It then does the same for other blobs in the form until it gets to the last blob.
If the positional information of the selected blob in the form is equal to the positional information of the 
corresponding blob in the template, the algorithm adds a value of 1 to the listbox. If they are not equal, it does nothing and
continues executing other instructions. At the end of the iteration, the items in the listbox are summed up to derive the 
total score of the student. 
This software uses algorithms from the AForge.Net Framework to perform image processing and form marking tasks.

All rights reserved. Copyright 2014.
