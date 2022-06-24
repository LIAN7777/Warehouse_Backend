// pch.cpp: 与预编译标头对应的源文件

#include "pch.h"
#include <string>
using namespace std;

// 当使用预编译的头时，需要使用此源文件，编译才能成功。
extern "C" _declspec(dllexport) string Encrypt(string strProclaime)
{
    for (int i = 0; i < strProclaime.length(); i++)
    {
        if (strProclaime[i] >= '0' && strProclaime[i] < 'x')
            strProclaime[i] += 2;
        else if (strProclaime[i] == '8')
            strProclaime[i] = '0';
        else if (strProclaime[i] == '9')
            strProclaime[i] = '1';
        strProclaime[i] -= 32;
    }
    return strProclaime;
}