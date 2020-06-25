# NetCore3.1-WebApi-JWT

Web Api en .NET CORE 3.1
ABML Usuarios + JWT

### POST

https://localhost:44322/api/Account/Create 
{ 
    "email": "usuario@email.com", 
    "password": "Aa123456!" 
}  

### POST 

https://localhost:44322/api/Account/Login
{
    "email": "usuario@email.com", 
    "password": "Aa123456!" 
} 


***IMPORTANTE: en el create y en el login se crea el token que da acceso al resto de metodos***


### GET

https://localhost:44322/Login/GetAll

### GET

string userId = ''; 
https://localhost:44322/Login/GetUserById/ + userId 

### DELETE 

string userId = ''; 
https://localhost:44322/Login/Eliminar/ + userId  

### PUT

string userId = ''; 
https://localhost:44322/Login/Editar 
{ 
    "id": userId, 
	"email": "email-modificado@email-modificado.com" 
} 

(tiene mas propiedades, pero hay que enviarle estas como mínimo) 
