/*
Author: Daniel McGuire

Purpose: MathBotCLI Development Header
*/
#ifndef MathBot_CLIENT_H
#define MathBot_CLIENT_H

#ifdef _WIN32
    #define DLL_IMPORT __declspec(dllimport)
#else
    #define DLL_IMPORT
#endif

extern "C" {
    DLL_IMPORT void MBver();
    DLL_IMPORT double calc2(double operand1, const char* op, double operand2);
    DLL_IMPORT double calc1(const char* op, double operand);
}

#endif // CALCULATOR_CLIENT_H
