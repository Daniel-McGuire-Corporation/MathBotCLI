#ifndef MATHBOTCLI_H
#define MATHBOTCLI_H

#ifdef _WIN32
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT
#endif

extern "C" {
    void MBver();
    double calc2(double operand1, const char* op, double operand2);
    double calc1(const char* op, double operand);
}

#endif // MATHBOTCLI_H
