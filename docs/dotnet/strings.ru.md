# strings

## Разница между String и StringBuilder в C#

- `String` является неизменяемым типом данных, в то время как `StringBuilder` представляет изменяемую последовательность символов.
- При частых операциях изменения строк лучше использовать `StringBuilder`, чтобы избежать создания большого количества временных объектов `String`.
