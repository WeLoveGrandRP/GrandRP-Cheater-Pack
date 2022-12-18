import random

def generate_random_text():
  symbols = '0123456789ABCDEF'
  random_text = ''.join(random.choices(symbols, k=4)) + '-' + ''.join(random.choices(symbols, k=4))
  return random_text

random_text = generate_random_text()
print(random_text)
