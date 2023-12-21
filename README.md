# 2023-Csharp-Final
The Final Homework project of C# class 2023
# Helpers Instructions
There are a few helpers created to simplify our work. The instrustions are down below.

All the helpers are under namespace `Shnuro.Helpers`
## MP3Helper
Used to operate .mp3 files.
### <1> MciPlay
Declaration:
```csharp
public static void MciPlay(string strFileName);
```
Usage : **Open** and **Play** a .mp3 file which `strFileName` indicates.
### <2> MciPause
Declaration:
```csharp
public static void MciPause(string strFileName);
```
Usage : **Pasue** a playing .mp3 file which `strFileName` indicates.
### <3> MciResume
Declaration:
```csharp
public static void MciResume(string strFileName);
```
Usage : **Resume** a paused .mp3 file which `strFileName` indicates.
### <4> MciClose
Declaration:
```csharp
public static void MciClose(string strFileName);
```
Usage : **Close** a .mp3 file which `strFileName` indicates, it won't restart until you play it..
## SQLHelper
### <1> isBlank
Declaration:
```csharp
public static bool isBlank(string str);
```
Usage : Returns whether the string `str` is null or empty.
