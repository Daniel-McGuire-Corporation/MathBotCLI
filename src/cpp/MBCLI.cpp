// MBCLI.cpp
/*
MathBotCLI WIP

Author: Daniel McGuire
*/
#include <stdio.h>
#include <iostream>
#include <sstream>
#include <cmath>
#include <string>
#include <iomanip>
using namespace std;

//declarations
#include <iostream>
#include <cmath>
#include <string>
#include <stdexcept>

// Function declarations
void displayUsage();
double calculate(double operand1, const std::string& op, double operand2);
double calculate(const std::string& op, double operand);

// Function definitions
void displayUsage() {
    std::cout << "Usage:\n"
              << "  calc [options] <operand1> <operator> <operand2>\n\n"
              << "Options:\n"
              << "  -h, --help           Display this help message.\n"
              << "  -v, --version        Display the version of the calculator.\n\n"
              << "Operators:\n"
              << "  +                    Addition\n"
              << "  -                    Subtraction\n"
              << "  *                    Multiplication\n"
              << "  /                    Division\n"
              << "  ^                    Exponentiation\n"
              << "  sqrt                 Square root (only requires one operand)\n\n"
              << "Examples:\n"
              << "  Addition:\n"
              << "    calc 2 + 3\n"
              << "    Output: 5\n\n"
              << "  Subtraction:\n"
              << "    calc 5 - 2\n"
              << "    Output: 3\n\n"
              << "  Multiplication:\n"
              << "    calc 3 * 4\n"
              << "    Output: 12\n\n"
              << "  Division:\n"
              << "    calc 10 / 2\n"
              << "    Output: 5\n\n"
              << "  Exponentiation:\n"
              << "    calc 2 ^ 3\n"
              << "    Output: 8\n\n"
              << "  Square Root:\n"
              << "    calc sqrt 16\n"
              << "    Output: 4\n\n"
              << "Notes:\n"
              << "  - Ensure there are spaces between the operands and the operator.\n"
              << "  - For square root calculations, only provide one operand.\n"
              << "  - The calculator does not support negative numbers or complex operations at this time.\n";
}


double calculate(double operand1, const std::string& op, double operand2) {
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

double calculate(const std::string& op, double operand) {
    if (op == "sqrt") {
        if (operand < 0) throw std::invalid_argument("Error: Square root of negative number.");
        return std::sqrt(operand);
    }
    throw std::invalid_argument("Invalid operator");
}

int main(int argc, char* argv[]) {
    std::string copyright = "(C) 2024 Daniel McGuire Corporation";
    std::string app = "MathBotCLI";
    std::string ver = " Internal C++ Alpha";
    std::cout << copyright << std::endl;
    std::cout << app << ver << std::endl;
    std::cout << std::endl;
    if (argc < 2) {
        displayUsage();
        return 1;
    }

    std::string arg1 = argv[1];

    if (arg1 == "-h" || arg1 == "--help") {
        displayUsage();
        return 0;
    }

    if (arg1 == "-v" || arg1 == "--version") {
        std::cout << ver << std::endl;
        return 0;
    }

    try {
        if (arg1 == "sqrt") {
            if (argc != 3) {
                std::cerr << "Error: sqrt operation requires exactly one operand.\n";
                return 1;
            }
            double operand = std::stod(argv[2]);
            double result = calculate("sqrt", operand);
            std::cout << "Output: " << result << "\n";
        } else {
            if (argc != 4) {
                std::cerr << "Error: operation requires two operands and one operator.\n";
                return 1;
            }
            double operand1 = std::stod(argv[1]);
            std::string op = argv[2];
            double operand2 = std::stod(argv[3]);
            double result = calculate(operand1, op, operand2);
            std::cout << "Output: " << result << "\n";
        }
    } catch (const std::invalid_argument& e) {
        std::cerr << "Error: " << e.what() << "\n";
        return 1;
    } catch (const std::exception& e) {
        std::cerr << "Error: " << e.what() << "\n";
        return 1;
    }

    return 0;
}