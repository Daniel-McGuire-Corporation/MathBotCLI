#ifndef CALCULATOR_CLIENT_H
#define CALCULATOR_CLIENT_H

#ifdef _WIN32
    #define DLL_IMPORT __declspec(dllimport)
#else
    #define DLL_IMPORT
#endif

extern "C" {
    DLL_IMPORT void displayUsage();
    DLL_IMPORT void displayVersion();
    DLL_IMPORT double calculate(double operand1, const char* op, double operand2);
    DLL_IMPORT double calculate(const char* op, double operand);
}

#endif // CALCULATOR_CLIENT_H
