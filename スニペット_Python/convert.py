import json


cells = json.load(open(file="./スニペット_Python/スニペット集.ipynb", encoding="UTF-8", mode="r"))["cells"]

result_file = "./スニペット_Python/README.md"

with open(file=result_file, encoding="UTF-8", mode="w") as txt:
    for content in cells:
        if content["cell_type"] == "code":
            try:
                language = content["metadata"]["vscode"]["languageId"]
            except KeyError:
                language = "python"
            txt.writelines([f"\n\n```{language}\n"])
            txt.writelines(content["source"])
            txt.writelines(["\n```\n\n"])
        else:
            txt.writelines(content["source"])

with open(file=result_file, encoding="UTF-8", mode="r") as txt:
    content = txt.read()

# 過剰な改行を削除
with open(file=result_file, encoding="UTF-8", mode="w") as txt:
    txt.write(content.replace("\n\n\n", "\n\n"))
