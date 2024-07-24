/*
Author: Daniel McGuire

Purpose: MathBotCLI C++ DLL
*/
#include "MBCLI.h"
#include <iostream>
#include <cmath>
#include <stdexcept>

void MBver() {
    std::string ver = "MathBotSO Alpha";
    std::cout << ver << std::endl;
}

double calc2(double operand1, const std::string& op, double operand2) {
    if (op == "+") return operand1 + operand2;
    if (op == "-") return operand1 - operand2;
    if (op == "*") return operand1 * operand2;
    if (op == "/") {
        if (operand2 == 0) throw std::invalid_argument("Error: Division by zero.");
        return operand1 / operand2;
    }
    if (op == "^") return std::pow(operand1, operand2);
    throw std::invalid_argument("Invalid operator");
}

double calc1(const std::string& op, double operand) {
    if (op == "sqrt") {
        if (operand < 0) throw std::invalid_argument("Error: Square root of negative number.");
        return std::sqrt(operand);
    }
    throw std::invalid_argument("Invalid operator");
}
