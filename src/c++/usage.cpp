//
//  usage.cpp
//  MathBotCLI
//
//  Created by Daniel McGuire on 8/27/24.
//
// Orints Help for MathBotCLI

#include "usage.hpp"
#include <iostream>
void displayUsage() {
    std::cout << "Usage:\n"
              << "  calc [options] <operand1> <operator> <operand2>\n\n"
              << "Options:\n"
              << "  -h, --help           Display this help message.\n"
              << "  -v, --version        Display the version of the calculator.\n\n"
              << "Operators:\n"
              << "  p                    Addition\n"
              << "  m                    Subtraction\n"
              << "  t                    Multiplication\n"
              << "  d                    Division\n"
              << "  ^                    Exponentiation\n"
              << "  sqrt                 Square root (only requires one operand)\n\n"
              << "Examples:\n"
              << "  Addition:\n"
              << "    calc 2 p 3\n"
              << "    Output: 5\n\n"
              << "  Subtraction:\n"
              << "    calc 5 m 2\n"
              << "    Output: 3\n\n"
              << "  Multiplication:\n"
              << "    calc 3 t 4\n"
              << "    Output: 12\n\n"
              << "  Division:\n"
              << "    calc 10 d 2\n"
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
