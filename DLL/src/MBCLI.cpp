#include "MBCLI.hpp"
#include <iostream>
#include <cmath>
#include <stdexcept>
#include <cstring>

void MBver() {
    std::string name = "MathBotSO Alpha";
    std::string ver = "0.1.0.71.2030";
    std::cout << name << " " << ver << std::endl;
}

double calc2(double operand1, const char* op, double operand2) {
    std::string op_str(op);
    if (op_str == "+") return operand1 + operand2;
    if (op_str == "-") return operand1 - operand2;
    if (op_str == "*") return operand1 * operand2;
    if (op_str == "/") {
        if (operand2 == 0) throw std::invalid_argument("Error: Division by zero.");
        return operand1 / operand2;
    }
    if (op_str == "^") return std::pow(operand1, operand2);
    throw std::invalid_argument("Invalid operator");
}

double calc1(const char* op, double operand) {
    std::string op_str(op);
    if (op_str == "sqrt") {
        if (operand < 0) throw std::invalid_argument("Error: Square root of negative number.");
        return std::sqrt(operand);
    }
    throw std::invalid_argument("Invalid operator");
}
