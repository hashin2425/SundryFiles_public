# Commit Prefix

コミットメッセージ `[Fix] 〇〇のために△△を追加` のプレフィックスを書くのが面倒なので付与するソフトを作りました。

[ここで公開しています。](https://github.com/hashin2425/SundryFiles_public/releases/tag/Commit_Prefix)

## 機能

![git](https://user-images.githubusercontent.com/41288293/200151513-45f542db-7615-4396-9d49-c1a09fc1c51e.gif)

- コメントを入力し、項目を選ぶとプレフィックス付きのテキストがクリップボードにコピーされます。スペルミスの可能性を減らすことができます。
- コメントを入力し始めると最前面に表示され、クリアを押すと最前面表示が解除されます。
- コメントがアルファベットで始まる場合、はじめの文字は大文字に変換されます。

## プレフィックス

[Angular.js/DEVELOPERS.md](https://github.com/angular/angular.js/blob/master/DEVELOPERS.md#type)を参考にしています。

| プレフィックス | 意味                               |
| -------------- | ---------------------------------- |
| Feature        | 新しい機能の追加                   |
| Fix            | バグ修正                           |
| Docs           | ドキュメント・コメントの変更       |
| Style          | フォーマット(空白・コロン)の変更   |
| Refactor       | コードの改善                       |
| Optimize       | アルゴリズムの改善・効率化         |
| Test           | テスト関連                         |
| Init           | プロジェクトの初期コミット         |
| Chore          | ビルド・補助ツール・ライブラリ関連 |
