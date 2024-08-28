//
//  main.cpp
//  MathBotCLI
//
//  Created by Daniel McGuire on 8/27/24.
//
// Command Line Calculator

#include <stdio.h>
#include <iostream>
#include <sstream>
#include <cmath>
#include <string>
#include <iomanip>
#include "usage.hpp"
using namespace std;

double calculate(double operand1, const std::string& op, double operand2) {
    if (op == "p") return operand1 + operand2;
    if (op == "m") return operand1 - operand2;
    if (op == "t") return operand1 * operand2;
    if (op == "d") {
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
    std::string app = "MathBotCLI macOS Alpha";
    std::string ver = "Alpha 0.1";
    std::cout << copyright << std::endl;
    std::cout << app << std::endl;
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
