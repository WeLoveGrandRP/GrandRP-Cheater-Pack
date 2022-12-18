import random
import requests

url = "https://raw.githubusercontent.com/Domenik1408/50k-random-names/main/names.txt"

# Hole den Text der URL
response = requests.get(url)

# Teile den Text in einzelne Zeilen auf
lines = response.text.split("\n")

# Wähle eine zufällige Zeile aus
random_line = random.choice(lines)

# Gib die zufällige Zeile aus
print(random_line)
