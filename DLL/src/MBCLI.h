#ifndef MBCLI_H
#define MBCLI_H

#ifdef _WIN32
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT
#endif

#include <string>

DLL_EXPORT void MBver();
DLL_EXPORT double calc2(double operand1, const std::string& op, double operand2);
DLL_EXPORT double calc1(const std::string& op, double operand);

#endif // MBCLI_H
