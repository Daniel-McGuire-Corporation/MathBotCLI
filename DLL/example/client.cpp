#include <iostream>
#include "MathBotCLI.h"

int main() {
    // Print the version of the DLL
    MBver();

    // Perform addition
    double result = calc2(5.0, "+", 3.0);
    std::cout << "Result of 5.0 + 3.0 = " << result << std::endl;

    // Perform square root
    try {
        double sqrtResult = calc1("sqrt", 16.0);
        std::cout << "Square root of 16.0 = " << sqrtResult << std::endl;
    } catch (const std::invalid_argument& e) {
        std::cerr << e.what() << std::endl;
    }

    return 0;
}
