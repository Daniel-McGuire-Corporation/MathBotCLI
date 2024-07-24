#include <iostream>
#include "MathBotCLI.h"

int main() {
    MBver();
    double result = calc2(5.0, "+", 3.0);
    std::cout << "Result of calc2: " << result << std::endl;
    result = calc1("sqrt", 16.0);
    std::cout << "Result of calc1: " << result << std::endl;
    return 0;
}
