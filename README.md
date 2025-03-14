# This Simple application can use for local TwinCAT/BSD repository server. 

You can download very simple the actual repositroy with this powershell script.

Link to Github Sample: (https://github.com/Beckhoff/twincatbsd-tools/tree/master/Backup-TCBSDRepo)

> [!WARNING]
> Please look Firewall settings by using application



### 1. Copy downloaded files to this folder
![image](https://github.com/user-attachments/assets/3c6e89c3-a871-437c-a06b-84b6d357ff34)

### 2. Start TwinCatBsdRepositoryServerConsole.exe
![image](https://github.com/user-attachments/assets/38631cdd-3bcf-4ba2-9612-1f11fb45c2e8)
   
### 4.  Login with ssh other local control with monitor
   
### 5. Change Repository configuration file by Tc/Bsd Target
   Path: /etc/pkg/TCBSD.conf
> [!TIP]
> doas ee /etc/pkg/TCBSD.conf
   
   
![image](https://github.com/user-attachments/assets/114045c1-cbdc-442a-9f90-bc295777d634)

### 6. You can use normaly pkg command by Tc/BSD
### Sample pkg Update 

![image](https://github.com/user-attachments/assets/0fcb8e89-d7e5-474c-91cb-737e134f3406)

### Working fine

![image](https://github.com/user-attachments/assets/8ff3f4e1-51ae-4656-ba5c-880135270525)

# Configuration Port
You can change the port for Webserver by config.josn

File config.json
