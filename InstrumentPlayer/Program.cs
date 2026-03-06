using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 악기 연주회 ===");

foreach (var instrument in new Instrument[]
{
    new Piano("그랜드 피아노"),
    new Guitar("어쿠스틱 기타"),
    new Drum("락 드럼")
})
{
    instrument.Tune();
    instrument.Play();
    Console.WriteLine();
}