namespace ittengoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void DrawBtnClicked(object? sender, EventArgs e)
        {
            List<string> wordList = new List<string>();
            wordList.Add("あなたは本当に幸せになりたいと思っていますか？");
            wordList.Add("本当に勝ちたいなら、勝つ要因が3個必要だとしたら、100個用意しましょう");
            wordList.Add("〇〇〇(尊敬する人)なら、どうするだろうか");
            wordList.Add("努力をしていない天才はいません。天才とは、無意識に誰よりも努力してしまう人のことを言います。");
            wordList.Add("もし魔法が使えたら何をしますか");
            wordList.Add("一分間、目を閉じて深呼吸をしましょう");
            wordList.Add("1年後に芽が出るような種まきをしましょう");
            wordList.Add("逆境の時に笑えるか辛い顔をするかで、その後の未来が変わります");
            wordList.Add("いかにして待つかを知ること、これこそ成功の最大の秘訣である");
            wordList.Add("「天は自ら助くる者を助く」");
            wordList.Add("「自分もなれる」と思うか、「自分にはとてもなれない」と思うかが、人間一生の分かれ道です。「必ず自分もなれる！」と思いましょう。");
            wordList.Add("自分の悩み事や問題を紙に書き出してみましょう。");
            int wordListLength = wordList.Count;
            DateTime dt = DateTime.Now;
            int dtNum = int.Parse(dt.ToString("ddHHmmss"));
            int wordNum = dtNum % wordListLength;
            // メッセージボックス表示
            await DisplayAlertAsync("一転語", wordList[wordNum], "閉じる");
        }
    }
}
