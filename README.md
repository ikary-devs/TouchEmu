# TouchEmu

MMO Framework para construir un servidor privado de Dofus Touch en .NET 8

Fork de [bleugateau/Bolgrot](https://github.com/bleugateau/Bolgrot). Continuamos y actualizamos el proyecto migrando a **.NET 8** y modernizando las dependencias.

## Screenshots

Selección de servidor:
![Server selection](https://i.ibb.co/7RjcNb7/image.png)

Selección de personaje:
![Characters selection](https://i.ibb.co/bPw4fSR/image.png)

En juego:
![In game](https://i.ibb.co/JQZ8mDM/image.png)

## Proyectos

| Proyecto | Descripción |
|----------|-------------|
| `TouchEmu.Core.Ankama.Protocol` | Implementación del protocolo de red de Dofus Touch |
| `TouchEmu.Core.Common` | Red, managers, pathfinding y repositorios |
| `TouchEmu.Server.Auth` | Servidor de autenticación + proxy |
| `TouchEmu.Server.Game` | Servidor de juego (frames, NPC, personajes) |
| `dofus-asset-api` | API PHP/Symfony para assets de Dofus Touch |

## Requisitos

- .NET 8 SDK
- MySQL
- PHP 7.4+ (solo para dofus-asset-api)

## Compilar

```bash
dotnet build TouchEmu.sln
```

## Estado actual

El servidor compila y levanta correctamente.

**Autenticación**: completamente local, sin depender de los servidores de Ankama. Las cuentas se crean directamente en la base de datos MySQL. El cliente debe apuntar al servidor local en lugar de a los servidores oficiales.

**Protocolo**: el servidor exige la versión `1594`. El cliente de Dofus Touch utilizado debe coincidir con esta versión.

**Datos del juego**: para funcionar necesita los archivos `data/Npcs.json`, `data/Heads.json`, `data/Breeds.json` y `data/maps/`, extraídos del cliente oficial de Dofus Touch en Android.

## Pendiente

- [ ] Extracción y conversión de datos del juego desde el cliente Android
- [ ] Compatibilidad con versiones del cliente más recientes que la versión de protocolo `1594`