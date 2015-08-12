# WindowsAutoPrint
WEB APIにGETリクエストを送って更新チェックをします。  
新着データを確認したら指定したプリンタに対して印刷支持を出します。  
  
汎用的に使えるツールじゃないので、編集が必要です。参考程度に。  
特にAPIから帰ってくる値を適用すると、印刷部分のロジック編集が必要になると思います。  
  
## 処理内容  
・WebClient によるGetリクエスト送信  
・DynamicJsonによるパース  
・設定オブジェクトのシリアライズ・デシリアライズ  
・WEBサーバに配置された画像を読み込み印刷する  
  
## 設定オブジェクト
・自動更新のオンオフ  
・自動印刷のオンオフ  
・Getリクエストのパラメータクエリ　Key、Value  
・WebAPIのリクエスト先サーバ　URL  
・更新チェックAPIのアドレス  
・画像URLを返すAPIのアドレス  
  
##利用しているWebAPI仕様について
・新着データチェックAPI  
　optionalで設定オブジェクトのKey、Valueを受け取ってJsonの配列形式で返す。  
・画像URL取得API  
　画像を"priscription":{"url":"コンテキストルート以降のパス","thumb"}の形式で返すオブジェクトのJson配列形式で返す  
※RailsのGem[carrierwave](https://github.com/carrierwaveuploader/carrierwave)・[mini_magick](https://github.com/minimagick/minimagick)を利用してる形式  
  
  
##その他
C# VisualStudio2012にて開発  
利用ライブラリ  
DynamicJson　https://dynamicjson.codeplex.com/  
  