#include <iostream>
#include "MathBotCLI.hpp"

int generateRandomTwoDigitNumber() {
    return rand() % 90 + 10;  // Returns a number between 10 and 99
}


int main() {
    std::string ver = "1.1.2.2430";
    std::cout << "MathBotSO Test App - Version " << ver << std::endl;
    std::cout << "\n";
    srand(static_cast<unsigned int>(time(0)));
    double num1 = generateRandomTwoDigitNumber();
    double num2 = generateRandomTwoDigitNumber();
    double sqrtNum = generateRandomTwoDigitNumber();
    std::cout << "Using MathBotDLL Version:\n";
    MBver();
    double result = calc2(num1, "+", num2);
    std::cout << "\n";
    std::cout << num1 << " + " << num2 << std::endl;
    std::cout << "Result of calc2: " << result << std::endl;
    result = calc1("sqrt", sqrtNum);
    std::cout << sqrtNum << std::endl;
    std::cout << "Result of calc1: " << result << std::endl;
    return 0;
}
