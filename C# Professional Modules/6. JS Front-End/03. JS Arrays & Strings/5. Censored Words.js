function censore(text,consoredWord) {
    let censoredText = text.replaceAll(consoredWord,'*'.repeat(consoredWord.length));
    console.log(censoredText);
}

censore('Find the hidden word', 'hidden');