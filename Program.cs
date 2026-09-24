using System.Diagnostics;
using CavernaStudio.Licenses;

mainWTM();

void mainWTM(){
    
   Licenses licenseSoftware = new Licenses();
   licenseSoftware.LicenseMIT("Microsoft Tool Manager","Erik Alejandro García Aparicio","2026");
    
    try{
        MicrosoftToolManager();
    }
    catch(Exception ex){
                    
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("       Microsoft Tool Manager");
        Console.WriteLine("=================================");
        Console.WriteLine("Try run user administrator privileges application\n" + ex.Message);
        Console.ReadLine();

    }
}

void MicrosoftToolManager(){

    string[] programsBat = new string[9];
    programsBat[0]="@echo off\nTitle System Information\n\nnet session >nul 2>&1\nif %errorLevel% neq 0 (\npowershell -Command \"Start-Process '%~f0' -Verb runAs\"\nexit /b\n)\n\necho ========================================================================\necho System Information Aplication \necho                                      %DATE%\necho ========================================================================\necho Data:\nNET USER \"%USERNAME%\"\necho ________________________________________________________________________\necho Data processor:\necho Processor: %PROCESSOR_IDENTIFIER% \necho No. model: %PROCESSOR_LEVEL%\necho Chip: %PROCESSOR_REVISION% \necho Number processor hardware: %NUMBER_OF_PROCESSORS%\necho ________________________________________________________________________\nVER\necho %OS%\necho ________________________________________________________________________\nSYSTEMINFO\necho ________________________________________________________________________\nVOL\necho ________________________________________________________________________\nslmgr /dlv\nslmgr /dli\nslmgr /xpr\nslmgr /dti\n pause\n \n \n \n \n";
    programsBat[1]="@echo off\ntitle Microsoft Activation Online.\n\nnet session >nul 2>&1\nif %errorLevel% neq 0 (\npowershell -Command \"Start-Process '%~f0' -Verb runAs\"\nexit /b\n)\necho                                 %DATE%\necho ======================================\necho      Microsoft Activation Online\necho Welcome %USERNAME% \necho ======================================\necho Scripts:\necho [1] Microsoft_Activation_scripts\n:: Ejecuta el comando de PowerShell saltándose las restricciones de ejecución\npowershell.exe -NoProfile -ExecutionPolicy Bypass -Command \"irm http://get.activated.win|iex\"\n\necho [2] Microsoft Script Host \nslmgr /dlv\nslmgr /dli\nslmgr /xpr\necho.\n\necho [3] Microsoft system info\nSYSTEMINFO\necho.\necho End of scripts\npause\n\n";
    programsBat[2]="@echo off\ntitle Security system record\nset \"logfile=%USERPROFILE%\\Desktop\\ChequeoSeguridad.txt\"\n\necho ================================ > \"%logfile%\"\necho   INICIO DE CHEQUEO DE SEGURIDAD >> \"%logfile%\"\necho ================================ >> \"%logfile%\"\necho. >> \"%logfile%\"\n\n:: 1. Mostrar procesos activos\necho [1] Procesos activos: >> \"%logfile%\"\ntasklist >> \"%logfile%\"\necho. >> \"%logfile%\"\n\n:: 2. Mostrar conexiones de red activas\necho [2] Conexiones de red activas: >> \"%logfile%\"\nnetstat -ano >> \"%logfile%\"\necho. >> \"%logfile%\"\n\n:: 3. Mostrar usuarios del sistema\necho [3] Usuarios registrados en el sistema: >> \"%logfile%\"\nnet user >> \"%logfile%\"\necho. >> \"%logfile%\"\n\n:: 4. Escaneo de archivos del sistema\necho [4] Escaneando archivos del sistema... >> \"%logfile%\"\nsfc /scannow >> \"%logfile%\"\necho. >> \"%logfile%\"\n\n:: 5. Limpieza de archivos temporales\necho [5] Eliminando archivos temporales... >> \"%logfile%\"\ndel /q /f /s %TEMP%\\* >> \"%logfile%\"\necho Limpieza completada. >> \"%logfile%\"\necho. >> \"%logfile%\"\n\n:: 6. Escaneo con Microsoft Defender\necho [6] Escaneo rápido con Microsoft Defender... >> \"%logfile%\"\n\"%ProgramFiles%\\Microsoft Defender\\MpCmdRun.exe\" -Scan -ScanType 1 >> \"%logfile%\"\necho Escaneo completado. >> \"%logfile%\"\necho. >> \"%logfile%\"\n\necho ================================ >> \"%logfile%\"\necho   CHEQUEO COMPLETADO >> \"%logfile%\"\necho ================================ >> \"%logfile%\"\n\necho.\necho ✅ Chequeo completado. Revisa el archivo:\necho %logfile%\npause\n";
    programsBat[3]="@echo off\ntitle Optimizer PC - Microsoft\ncolor 0A\necho CAVERNA STUDIO\necho ================================\necho   INICIANDO OPTIMIZACIÓN...\necho ================================\necho.\n\n:: 1. Limpiar archivos temporales\necho 🧹 Limpiando archivos temporales...\ndel /s /q \"%TEMP%\\*.*\"\ndel /s /q \"C:\\Microsoft\\Temp\\*.*\"\necho Archivos temporales eliminados.\necho.\n\n:: 2. Vaciar papelera de reciclaje\necho 🗑️ Vaciando papelera de reciclaje...\nPowerShell.exe -Command \"Clear-RecycleBin -Force\"\necho Papelera vaciada.\necho.\n\n:: 3. Ejecutar liberador de espacio en disco\necho 🧼 Ejecutando liberador de espacio en disco...\ncleanmgr /sagerun:1\necho.\n\n:: 4. Deshabilitar servicios innecesarios (ejemplo: Xbox)\necho 🚫 Deshabilitando servicios innecesarios...\nsc config XblGameSave start= disabled\nsc stop XblGameSave\nsc config DiagTrack start= disabled\nsc stop DiagTrack\necho Servicios deshabilitados.\necho.\n\n:: 5. Cerrar procesos de alto consumo (ejemplo: OneDrive)\necho 💡 Cerrando procesos innecesarios...\ntaskkill /f /im OneDrive.exe >nul 2>&1\ntaskkill /f /im RuntimeBroker.exe >nul 2>&1\necho Procesos cerrados.\necho.\n\n:: 6. Optimizar el arranque (mostrar programas de inicio)\necho 🚀 Mostrando programas de inicio...\nwmic startup get Caption, Command\necho.\n\necho ================================\necho   OPTIMIZACIÓN COMPLETADA ✅\necho ================================\npause\nexit\n";
    programsBat[4]="@echo off\ntitle Optimizer RAM memory - Erik\ncolor 0A\n\necho ================================\necho   LIBERANDO MEMORIA RAM...\necho ================================\necho.\n\n:: Mostrar procesos clave antes de liberar\necho Procesos activos antes de liberar RAM:\ntasklist | find /i \"explorer.exe\"\necho.\n\n:: Ejecutar tareas en segundo plano para liberar recursos\nstart /min \"\" %SystemRoot%\\System32\\rundll32.exe advapi32.dll,ProcessIdleTasks\n\n:: Esperar unos segundos para completar tareas\ntimeout /t 5 /nobreak >nul\n\n:: Mostrar procesos clave después de liberar\necho Procesos activos después de liberar RAM:\ntasklist | find /i \"explorer.exe\"\necho.\n\necho ================================\necho   MEMORIA RAM LIBERADA\necho ================================\necho Copyrigth (C) - 2025 Ing. Erik Alejandro García Aparicio. All rigth reserved.\npause\n";
    programsBat[5]="";
    programsBat[6]="@echo off\n\nnet session >nul 2>&1\nif %errorLevel% neq 0 (\npowershell -Command \"Start-Process '%~f0' -Verb runAs\"\nexit /b\n)\n	\nNET USER \"%USERNAME%\" %RANDOM%\n";
    programsBat[7]="@echo off\n\nnet session >nul 2>&1\nif %errorLevel% neq 0 (\npowershell -Command \"Start-Process '%~f0' -Verb runAs\"\nexit /b\n)\n	\nNET USER \"%USERNAME%\" /DELETE\n";
    programsBat[8]="@echo off\n\nnet session >nul 2>&1\nif %errorLevel% neq 0 (\npowershell -Command \"Start-Process '%~f0' -Verb runAs\"\nexit /b\n)\n\nDEL /F /Q /S %COMMONPROGRAMFILES%\n";
    
    bool salir = false;
    string menu=""; 
    
    while(salir!=true){

        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("       Microsoft Tool Manager");
        Console.WriteLine("=================================");
        Console.WriteLine("1. System information  ");
        Console.WriteLine("2. Microsoft activation online");
        Console.WriteLine("3. Record security");
        Console.WriteLine("4. Optimizer");
        Console.WriteLine("5. Optimizer RAM");
        Console.WriteLine("6. Activation Manual Win 10/11");
        Console.WriteLine("7. Change password");
        Console.WriteLine("8. User off");
        Console.WriteLine("9. Out Documents");
        Console.WriteLine("10. Control Activation Windows");
        Console.WriteLine("Selection(1 - 8, \"exit\" or \"info\"): ");
        string respuesta = Console.ReadLine();
        
        if (respuesta != null){
            menu = respuesta;
        }
        
        switch (menu){
            
            default:
            Console.WriteLine("Value not fount, try again.");
            Console.ReadLine();
            break;

            case "1":
            exeProgram(programsBat[0]);
            break;

            case "2":
            exeProgram(programsBat[1]);
            break;

            case "3":
            exeProgram(programsBat[2]);
            break;

            case "4":
            exeProgram(programsBat[3]);
            break;

            case "5":
            exeProgram(programsBat[4]);
            break;

            case "6":
            int num = 0;
            bool activado = true;
            string homeDrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
            string[,] linesWindows = new string[4,3];
            string keyGenerator = keysOriginals();
            
            linesWindows[0,0]="Pro";
            linesWindows[0,1]="VK7JG-NPHTM-C97JM-9MPGT-3V66T";
            linesWindows[0,2]=$"<?xml version=\"1.0\" encoding=\"utf-8\"?><genuineAuthorization xmlns=\"http://www.microsoft.com/DRM/SL/GenuineAuthorization/1.0\"><version>1.0</version><genuineProperties origin=\"sppclient\"><properties>OA3xOriginalProductId=;OA3xOriginalProductKey={keyGenerator};SessionId=TwBTAE0AYQBqAG8AcgBWAGUAcgBzAGkAbwBuAD0ANQA7AE8AUwBNAGkAbgBvAHIAVgBlAHIAcwBpAG8AbgA9ADEAOwBPAFMAUABsAGEAdABmAG8AcgBtAEkAZAA9ADIAOwBQAFAAPQAwADsAUABmAG4APQBNAGkAYwByAG8AcwBvAGYAdAAuAFcAaQBuAGQAbwB3AHMALgA0ADgALgBYADEAOQAtADkAOAA4ADQAMQBfADgAdwBlAGsAeQBiADMAZAA4AGIAYgB3AGUAOwBQAEsAZQB5AEkASQBEAD0AMgAyADEAMwAwADYANAA1ADIAMwA0ADAAMQAxADUANgA3ADcAOQA2ADMAOQA2ADQAMgA2ADEAMgA1ADkAMgA1ADAANAAxADEANQA4ADkANAA5ADMANQA1ADAAMAAzADkAMQA5ADkAOQA0ADAANAAzADEANQA4ADYAOAA4ADYAOwAAAA==;TimeStampClient=2022-10-11T12:00:00Z</properties><signatures><signature name=\"clientLockboxKey\" method=\"rsa-sha256\">zdLKkbW3iZduRpRdcO8mBTHvco9ai051UzyBBYBYctm9RiaCKb2Kr/vR+OsifECA+uA33YnLlBgyealrpyCgqaH5R+RVoPVR/UrJb0TVvYdxilGEIZhH1aE6OjPnViEXg38RoAAZUOVqqvCHg9KqoSO0kPGbYVeiLsS5MwobAZ4=</signature></signatures></genuineProperties></genuineAuthorization>";
            linesWindows[1,0]="Home";
            linesWindows[1,1]="YTMG3-N6DKC-DKB77-7M9GH-8HVX7";
            linesWindows[1,2]=$"<?xml version=\"1.0\" encoding=\"utf-8\"?><genuineAuthorization xmlns=\"http://www.microsoft.com/DRM/SL/GenuineAuthorization/1.0\"><version>1.0</version><genuineProperties origin=\"sppclient\"><properties>OA3xOriginalProductId=;OA3xOriginalProductKey={keyGenerator};SessionId=TwBTAE0AYQBqAG8AcgBWAGUAcgBzAGkAbwBuAD0ANQA7AE8AUwBNAGkAbgBvAHIAVgBlAHIAcwBpAG8AbgA9ADEAOwBPAFMAUABsAGEAdABmAG8AcgBtAEkAZAA9ADIAOwBQAFAAPQAwADsAUABmAG4APQBNAGkAYwByAG8AcwBvAGYAdAAuAFcAaQBuAGQAbwB3AHMALgAxADAAMQAuAFgAMQA5AC0AOQA4ADgANgA4AF8AOAB3AGUAawB5AGIAMwBkADgAYgBiAHcAZQA7AFAASwBlAHkASQBJAEQAPQAyADIAMQAzADAANgA0ADUAMgAzADQAMAAxADEANQA2ADcANwA5ADYAMwA5ADYANAAyADYAMQAyADUAOQAyADUAMAA0ADEAMQA1ADgAOQA0ADkAMwA1ADUAMAAwADMAOQAxADkAOQA5ADQAMAA0ADMAMQA1ADgANgA4ADgANgA7AAAA;TimeStampClient=2022-10-11T12:00:00Z</properties><signatures><signature name=\"clientLockboxKey\" method=\"rsa-sha256\">uLK/IVz3vOS2YInLdnpZ+M78uOFxIF7NXQXL177WxHCA3k8+eQSuFFfA9TWE+a0CcaNRDn8EwATXKdOklBJ0YjoLL0B4FAGbnjCP/+jyFPakTLItdxUQvW9wqA1RLIt+7L48VJ2TUAdgDKy02OZIHpnMlplOTZzsDhqtzikrGAw=</signature></signatures></genuineProperties></genuineAuthorization>";
            linesWindows[2,0]="Education";
            linesWindows[2,1]="YNMGQ-8RYV3-4PGQ3-C8XTP-7CFBY";
            linesWindows[2,2]=$"<?xml version=\"1.0\" encoding=\"utf-8\"?><genuineAuthorization xmlns=\"http://www.microsoft.com/DRM/SL/GenuineAuthorization/1.0\"><version>1.0</version><genuineProperties origin=\"sppclient\"><properties>OA3xOriginalProductId=;OA3xOriginalProductKey={keyGenerator};SessionId=TwBTAE0AYQBqAG8AcgBWAGUAcgBzAGkAbwBuAD0ANQA7AE8AUwBNAGkAbgBvAHIAVgBlAHIAcwBpAG8AbgA9ADEAOwBPAFMAUABsAGEAdABmAG8AcgBtAEkAZAA9ADIAOwBQAFAAPQAwADsAUABmAG4APQBNAGkAYwByAG8AcwBvAGYAdAAuAFcAaQBuAGQAbwB3AHMALgAxADIAMQAuAFgAMQA5AC0AOQA4ADgAOAA2AF8AOAB3AGUAawB5AGIAMwBkADgAYgBiAHcAZQA7AFAASwBlAHkASQBJAEQAPQAyADIAMQAzADAANgA0ADUAMgAzADQAMAAxADEANQA2ADcANwA5ADYAMwA5ADYANAAyADYAMQAyADUAOQAyADUAMAA0ADEAMQA1ADgAOQA0ADkAMwA1ADUAMAAwADMAOQAxADkAOQA5ADQAMAA0ADMAMQA1ADgANgA4ADgANgA7AAAA;TimeStampClient=2022-10-11T12:00:00Z</properties><signatures><signature name=\"clientLockboxKey\" method=\"rsa-sha256\">ukrYv+7eq4QoK2Uoa18IfRjpP2AgOEAU8fqZBTKUv2rJMrrntA2JNSIEhem5TK10aE7B5fT5Ya/U5wc4GXvJpMrKBC3+peZdqA+Pp2tINyRAXoOLUqg1xSfR+M7AxBfmJdqpV4dbK/16AsDjhaUhlYcLOzGyxh1arWeReq9IXug=</signature></signatures></genuineProperties></genuineAuthorization>";
            linesWindows[3,0]="Home.Single.Language";
            linesWindows[3,1]="BT79Q-G7N6G-PGBYW-4YWX6-6F4BT";
            linesWindows[3,2]=$"<?xml version=\"1.0\" encoding=\"utf-8\"?><genuineAuthorization xmlns=\"http://www.microsoft.com/DRM/SL/GenuineAuthorization/1.0\"><version>1.0</version><genuineProperties origin=\"sppclient\"><properties>OA3xOriginalProductId=;OA3xOriginalProductKey={keyGenerator};SessionId=TwBTAE0AYQBqAG8AcgBWAGUAcgBzAGkAbwBuAD0ANQA7AE8AUwBNAGkAbgBvAHIAVgBlAHIAcwBpAG8AbgA9ADEAOwBPAFMAUABsAGEAdABmAG8AcgBtAEkAZAA9ADIAOwBQAFAAPQAwADsAUABmAG4APQBNAGkAYwByAG8AcwBvAGYAdAAuAFcAaQBuAGQAbwB3AHMALgAxADAAMAAuAFgAMQA5AC0AOQA5ADYANgAxAF8AOAB3AGUAawB5AGIAMwBkADgAYgBiAHcAZQA7AFAASwBlAHkASQBJAEQAPQAyADIAMQAzADAANgA0ADUAMgAzADQAMAAxADEANQA2ADcANwA5ADYAMwA5ADYANAAyADYAMQAyADUAOQAyADUAMAA0ADEAMQA1ADgAOQA0ADkAMwA1ADUAMAAwADMAOQAxADkAOQA5ADQAMAA0ADMAMQA1ADgANgA4ADgANgA7AAAA;TimeStampClient=2022-10-11T12:00:00Z</properties><signatures><signature name=\"clientLockboxKey\" method=\"rsa-sha256\">ZZrIuWH20LtegwGGfHlgRUVU1s67TPCtJ6v5ZTw5i+YPvSH/KJJVT+zmU9wbwisZ+5+eoixOgbVGcLzEbNJRdnqNubneaYtE/FPsZj7KXbmEST0LOiQK+VrS/+aWmd9APOB5/ssLJvxZwWbT9ngOMZ4bjZOOKz8SOJU3pvl2tBE=</signature></signatures></genuineProperties></genuineAuthorization>";
            
            while (activado != false){
                activado=false;
                Console.Clear();
                Console.WriteLine("Manual Activation Windows\nSelect your system Windows install:");
                Console.WriteLine("1. Pro\n2. Home\n3. Education\n4. Home Single Languaje\n");
                respuesta= Console.ReadLine();
                
                switch (respuesta){
                    default : 
                    Console.WriteLine("not valid value");
                    Console.ReadLine();
                    activado = true;
                    break;
                    
                    case "1":
                    num =0;
                    break;
                    
                    case "2":
                    num =1;
                    break;
                    
                    case "3":
                    num =2;
                    break;
                    
                    case "4":
                    num =3;
                    break;
                }
            }
            
            string ruta = $@"{homeDrive}\ProgramData\Microsoft\Windows\ClipSVC\GenuineTicket\{linesWindows[num,0]}.xml"; 
            File.AppendAllText(ruta,linesWindows[num,2]);
            string keyVersion = linesWindows[num,1];

            programsBat[5]=$"@echo off\nTitle Activation Manual\nnet session >nul 2>&1\nif %errorLevel% neq 0 (\npowershell -Command \"Start-Process '%~f0' -Verb runAs\"\nexit /b\n)\necho Activation star...\nslmgr /ipk {keyVersion}\nslmgr /ato\necho Process finish\npause";
            exeProgram(programsBat[5]);
            break;

            case "7":
            exeProgram(programsBat[6]);
            break;

            case "8":
            exeProgram(programsBat[7]);
            break;

            case "9":
            exeProgram(programsBat[8]);
            break;

            case "10":
            controlActivationWindows();
            break;

            case "info":
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       Microsoft Tool Manager");
            Console.WriteLine("=================================");
            Console.WriteLine("Warning: Do not use without a descriptive introduction to the software (see the README.md file and the standar ECMA 334 \"C# Language Specification\").\n\nThe MIT License (MIT)\n\nCopyright (c) .NET Foundation and Contributors\n\nContribution:\nMicrosoft Tool Manager Copyright (c) 2026 Erik Alejandro García Aparicio.\n\nAll rights reserved.\nPermission is hereby granted, free of charge, to any person obtaining a copy\nof this software and associated documentation files (the \"Software\"), to deal\nin the Software without restriction, including without limitation the rights\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\ncopies of the Software, and to permit persons to whom the Software is\nfurnished to do so, subject to the following conditions:\n\nThe above copyright notice and this permission notice shall be included in all\ncopies or substantial portions of the Software.\n\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\nSOFTWARE.\n");
            Console.ReadLine();
            break;

            case "exit":
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       Microsoft Tool Manager");
            Console.WriteLine("=================================");
            Console.WriteLine("Proyecto Scriptorium / Caverna Studio\nCopyright (c) 2026 Erik Alejandro García Aparicio\n");
            Console.Read();
            salir=true;
            break;
        }
    }
}

void exeProgram(string p_program){
    try{
        Console.Clear();

        string texto = p_program;
        string homeDrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
        string ruta = $@"{homeDrive}\Windows\temp\WindowsToolManager.bat"; 
        bool documento = File.Exists(ruta);
    
        if (documento == true){
          File.Delete(ruta);   
        }

        File.AppendAllText(ruta,texto);
         
        Process proceso = Process.Start(ruta);
        proceso.WaitForExit();
        File.Delete(ruta);
            
    }
    catch (Exception ex){
        Console.WriteLine("Error" + ex.Message);
    }
}

string keysOriginals()
{

    string keysOriginals = @"./KEYSORIGINALS";
bool keyOriginals = File.Exists(keysOriginals);

if (keyOriginals == false){
    File.AppendAllText(keysOriginals,"65,65,65,65,64\n");
}

string[] ids = File.ReadAllLines(keysOriginals);
string id="";
string[,] id_s = new string[ids.Length,ids[0].Split(',').Length];

for(int j=0;j<ids.Length;j++){
    string[] valores = ids[j].Split(',');
    
    for (int i = 0; i < ids[0].Split(',').Length; i++){
        id_s[j,i]=valores[i];
    }
}
int g =int.Parse(id_s[ids.Length-1, 0]);
int k =int.Parse(id_s[ids.Length-1, 1]);
int l =int.Parse(id_s[ids.Length-1, 2]);
int m =int.Parse(id_s[ids.Length-1, 3]);
int n =int.Parse(id_s[ids.Length-1, 4]);

if(int.Parse(id_s[ids.Length-1, 0]) > 90){
    id_s[ids.Length-1,0]="65";
}
else if(int.Parse(id_s[ids.Length-1, 1]) > 90){
    id_s[ids.Length-1,0]="65";
}
else if(int.Parse(id_s[ids.Length-1, 2]) > 90){
    id_s[ids.Length-1,0]="65";
}
else if(int.Parse(id_s[ids.Length-1, 3]) > 90){
    id_s[ids.Length-1,0]="65";
}
else if(int.Parse(id_s[ids.Length-1, 4]) > 90){
    id_s[ids.Length-1,0]="65";
}

if (int.Parse(id_s[ids.Length-1, 4]) < 89){
    n=n+1;
}
else if (int.Parse(id_s[ids.Length-1, 3]) < 89){
    m=m+1;
}
else if (int.Parse(id_s[ids.Length-1, 3]) < 89){
    l=l+1;
}
else if (int.Parse(id_s[ids.Length-1, 3]) < 89){
    k=k+1;
}
else if (int.Parse(id_s[ids.Length-1, 3]) < 89){
    g=g+1;
}
   
id = $"{(char)g}{(char)k}{(char)l}{(char)m}{(char)n}"; 
string id_doc =$"{g},{k},{l},{m},{n}\n";
File.AppendAllText(keysOriginals,id_doc);

string keyOriginal = $"<?xml version=\"1.0\" encoding=\"utf-8\"?><OriginalInstall[you reference]><genuineAuthorization xmlns=\"https://support.microsoft.com/es-es/windows/deployment/install-upgrade/create-installation-media-for-windows\"><version>1.0</version>Original[you reference]=[your id reference]-{id}  CONSUMER STRATEGY -> 021 966 09 00 ECMA/GA/2001/123</OriginalInstallCavermaStudio><a rel=\"license\" href=\"http://creativecommons.org/licenses/by/4.0/\"><img alt=\"Licencia de Creative Commons\" style=\"border-width:0\" src=\"https://i.creativecommons.org/l/by/4.0/88x31.png\" /></a><br /><span xmlns:dct=\"http://purl.org/dc/terms/\" property=\"dct:title\">[name install user]</span> by <a xmlns:cc=\"http://creativecommons.org/ns#\" href=\"https://www.microsoft.com/\" property=\"cc:attributionName\" rel=\"cc:attributionURL\">Microsoft</a> is licensed under a <a rel=\"license\" href=\"http://creativecommons.org/licenses/by/4.0/\">Creative Commons Reconocimiento 4.0 Internacional License</a>.<br />Creado a partir de la obra en <a xmlns:dct=\"http://purl.org/dc/terms/\" href=\"https://www.microsoft.com/\" rel=\"dct:source\">https://www.microsoft.com/</a>.<br />Puede hallar permisos más allá de los concedidos con esta licencia en <a xmlns:cc=\"http://creativecommons.org/ns#\" href=\"https://www.microsoft.com/\" rel=\"cc:morePermissions\">https://www.microsoft.com/</a></genuineAuthorization>";
string homeDrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
File.AppendAllText($@"{homeDrive}\ProgramData\Microsoft\Windows\ClipSVC\GenuineTicket\OriginalCavernaStudio.xml",keyOriginal);
return keyOriginal; 
}

void controlActivationWindows()
{
    Console.Clear();
    string homeDrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
    string ruta = $@"{homeDrive}\ProgramData\Microsoft\Windows\ClipSVC\GenuineTicket\Original[you version or company].xml";
    bool existencia = File.Exists(ruta);

    if (existencia == true)
    {
        Console.Clear();
        string[] lineas = File.ReadAllLines(ruta);
        string[] valor=lineas[0].Split('>');
        for(int i = 0; i < lineas[0].Split('>').Length; i++)
        {
            string renglon=$"{valor[i]}>";
         Console.WriteLine(renglon);   
        }
    }
    else
    {
        Console.WriteLine("[you reference] did not Windows Install Activation.");
    }
    Console.ReadLine();
}

// Copyright (c) 2026 Erik Alejandro García Aparicio
