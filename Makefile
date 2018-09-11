config := Release

################################################################################

srcs := $(wildcard src/*)
bins := bin/$(config)/netstandard2.0/Unitility.dll

################################################################################

.PHONY: build clean rebuild

build: $(bins)

clean:
	rm -rf bin lib/*.dll

rebuild: clean build

$(bins): $(srcs) lib/UnityEngine.dll
	dotnet build -c $(config)

lib/UnityEngine.dll:
	ln -s $$(locate -e -n 1 '*/Editor/Data/Managed/UnityEngine.dll') $@