#ifndef MBCLI_H
#define MBCLI_H

#ifdef _WIN32
    #define DLL_EXPORT __declspec(dllexport)
#else
    #define DLL_EXPORT
#endif

extern "C" {
    DLL_EXPORT void MBver();
    DLL_EXPORT double calc2(double operand1, const char* op, double operand2);
    DLL_EXPORT double calc1(const char* op, double operand);
}

#endif // MBCLI_H
