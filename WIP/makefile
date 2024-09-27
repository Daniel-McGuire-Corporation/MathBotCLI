# Variables
SRC_DIR = src/main/java
BIN_DIR = build/classes
TEST_DIR = src/test/java
LIB_DIR = lib

# Main class to run
MAIN_CLASS = com.danielm.mbjava.calc

# Java compiler
JAVAC = javac
# Java runtime
JAVA = java

# Source files
SRC = $(wildcard $(SRC_DIR)/**/*.java)
# Class files
CLASS_FILES = $(patsubst $(SRC_DIR)/%.java,$(BIN_DIR)/%.class,$(SRC))

.PHONY: all run clean 

all: $(CLASS_FILES)

$(BIN_DIR)/%.class: $(SRC_DIR)/%.java
	mkdir -p $(BIN_DIR)
	$(JAVAC) -d $(BIN_DIR) $<

run: all
	$(JAVA) -cp $(BIN_DIR) $(MAIN_CLASS)

clean:
	rm -rf $(BIN_DIR)/*