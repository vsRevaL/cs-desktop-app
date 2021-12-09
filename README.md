# 🩸 Blood Sugar Diary 💻📋📊📝

## Introduction

This application was one of my university assignments, it helps the user to keep track of her/his blood sugar measurements

![img_4.png](images/img_4.png) |  ![img_5.png](images/img_5.png)
----------------------- | ---------------
![img_8.png](images/img_8.png) | ![img_7.png](images/img_7.png)


## How to run

- Data Connections - right click - Add Connection
- Browse the `Database1.mdf` (can be found in the project folder)
- Press <b>OK<b>

![img.png](img.png)

![img_3.png](img_3.png)

- Tools - NuGet Package Manager
- Package Manager Console
- `Scaffold-DbContext "here you paste the connection string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -Context PatientDB`
- Press Enter

![img_1.png](img_1.png)

- If red notification occurs, paste the command again with `-Force` at the end

![img_2.png](img_2.png)


<br>
<br>
<br>