/*
Author: Daniel McGuire

Purpose: MathBotCLI C++ DLL
*/
#include "MBCLI.h"
#include <iostream>
#include <cmath>
#include <cstring>  
#include <stdexcept>

void MBver() {
    std::cout << "MathBotCLI Alpha\n";
}

double calc2(double operand1, const char* op, double operand2) {
    if (std::strcmp(op, "+") == 0) return operand1 + operand2;
    if (std::strcmp(op, "-") == 0) return operand1 - operand2;
    if (std::strcmp(op, "*") == 0) return operand1 * operand2;
    if (std::strcmp(op, "/") == 0) {
        if (operand2 == 0) throw std::invalid_argument("Error: Division by zero.");
        return operand1 / operand2;
    }
    if (std::strcmp(op, "^") == 0) return std::pow(operand1, operand2);
    throw std::invalid_argument("Invalid operator");
}

double calc1(const char* op, double operand) {
    if (std::strcmp(op, "sqrt") == 0) {
        if (operand < 0) throw std::invalid_argument("Error: Square root of negative number.");
        return std::sqrt(operand);
    }
    throw std::invalid_argument("Invalid operator");
}
