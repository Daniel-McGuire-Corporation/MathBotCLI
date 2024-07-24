#include <iostream>
#include "MathBotCLI.h"

int main() {
    try {
        double result1 = calculate(2, "+", 3);
        std::cout << "2 + 3 = " << result1 << "\n";

        double result2 = calculate("sqrt", 16);
        std::cout << "sqrt 16 = " << result2 << "\n";
    } catch (const std::invalid_argument& e) {
        std::cerr << "Error: " << e.what() << "\n";
    }
    return 0;
}
