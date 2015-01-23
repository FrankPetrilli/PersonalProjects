#!/bin/bash

DIR=$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )

rm ~/.vimrc
ln -s $DIR/vimrc ~/.vimrc
rm -r ~/.vim
ln -s $DIR/vim ~/.vim
