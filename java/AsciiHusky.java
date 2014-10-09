// Frank Petrilli | frank@petril.li
// Prints a ASCII husky; though the husky itself is boring in terms of programming, the blank line printing method uses parameters and a for loop, and regular expressions were used to speed coding. 

public class AsciiHusky {
	public static void main(String[] args) {
		// Real simple. Just print each line as instructed. A println is used to make it drop lines, and vim made adding the System.out.println much much faster. shift+v, j, I, {text}, escape. | shift+v, :s,$,");,
		System.out.println("                                      DDD                        88O8           ");
		System.out.println("                                      I??$D                    87+++O           ");
		System.out.println("                                     8?7?+?8                  8+++??7           ");
		System.out.println("                                     O?7I??+?Z  ..  . +=  ,Z8?+=+77?I           ");
		System.out.println("                                     ?+7O$??$$DOO88ODD8DDO8$OO7=?$7??           ");
		System.out.println("                                      ~?777$Z8O88I$IZDDOIIZ8O7O?7Z$?Z           ");
		System.out.println("                                      I?$8D$$O8DO:,,:O8?,:::88$$OZI+            ");
		System.out.println("                                      7?ZZ8Z888O$:,,,,$:,,~:8D8I7$I7            ");
		System.out.println("                                       ?$DDD888I?7~:,,,,,,I$+I88Z87I            ");
		System.out.println("                                       DDDDDD8?~D8D7+,,::+8?+:OD88D,            ");
		System.out.println("                                      88DDDD7~=~~=+~,:,,,,,:~,~8DD8             ");
		System.out.println("                                      ZDDD$~,:,::,,:,:~~,,..,,.,I8D             ");
		System.out.println("                                     ZDD8?:~~~:,.,,,~=Z888O,,..:,Z              ");
		System.out.println("                                   D88DD8=:=:~~,,,,,=ZDD8DD:,.,::$              ");
		System.out.println("                                  DD8DDDDO?+~?~I~,,:=$DDDD8:.:::~O              ");
		System.out.println("                                :DDDDO8OZI+???7?D~,~+7O8OO7,::~:I               ");
		System.out.println("                               DDDDDZ77OD87$$III$D8+IODDD87~::~                 ");
		System.out.println("                            ~DD8DZ$ZZ$$$778OZ$$$?+DO8:III+,8:,                  ");
		System.out.println("                            8D8Z7$7?7$ZZ8D8DZ$$$$I?7D8?~++$,,                   ");
		System.out.println("                           DDDD87I+?I$Z8DDDDD87$$7$7+IODDO~,O                   ");
		System.out.println("                         DDDNNDD8$II7$88DNDDDOZO$$$$7I+~:.,:ZO                  ");
		System.out.println("                     DDNDNNDNDDDD$I7I7Z8DDDDDDDD877I7?I=:::=OZ                  ");
		System.out.println("                   8DND8DDNNDDDD8DIIZI$Z8DDDDDD8ZI$7+=~,:~?$O                   ");
		System.out.println("                  DNDD8O8NDDDDDO8D88Z$Z$ZODDDDDD$7?=:,~=?7$Z=                   ");
		System.out.println("                8DNDNDO7DNNNDDDDOO8D8O77$$Z8DDDD$Z7I?7~~+I$8                    ");
		System.out.println("              +DDNNNDO$Z8NNNDND888DD88$$$77Z7Z88ZZ$7I+=?I$Z$I                   ");
		System.out.println("            $DNNNDNDDZ$$8DNNDNNDDD8DDD8$7I??+?IO8OZ$7$$$7$O+                    ");
		System.out.println("           ZNNNNNDDDDZ$7$ZODDD888DDDDDDDZI?I~+~+?7$$ZO$O8O==.                   ");
		System.out.println("          $DNNNNDDD8D8Z777ZNNDDDDDD8DDDDDZ$??+~=~=?++Z888?:~                    ");
		System.out.println("        .8DNDNDD8DDDDD8O$$$DDDDDD88OOD8DDDDZZ7??~~~~==7Z?~+                     ");
		System.out.println("        ODDNDD88888DD8D8ZZZ8DDDDDD8ZO$I?O8DDDOZ$+==~~~=+??O~                    ");
		System.out.println("       7NNDN888OO88DD8888OZOD8DDDDDDOI~~==7ZO88OO777??+?II                      ");
		System.out.println("       DNDDOOOO888DNDD8DD8OO8OD88DDDZ?+::=+~=??=?++?+=+?7=                      ");
		System.out.println("     +DDDND8OZZOO88DDDDOD8O8OZ8DDOZO$8I~~~:==?+==~~~=~~:~                       ");
		System.out.println("     DDDDDOOOZZO8ODDDDDDDDDO8ZOD8Z$ZD8Z==~~=++=~~~:~~=~:~                       ");
		System.out.println("     DDDDD8OOO8OOD8DDDDDDD88ZO8D$$$OO887I~=+==+=~~~~~~~~                        ");
		System.out.println("     ,,,,,,,,,,,,,,,::::::::::::::::::::::,.,,,,,,,,,,,,			    ");
		// Call the blank method with a parameter of 3 to print 3 blank lines.
		blank(3);
		// The backslashes used in this bit of text make it a little messy, but regex made doing the character replacement trivial. e.g. s/\\/\\\\/g
		System.out.println("   _  _   _                      _                     ");
		System.out.println(" _| || |_| |                    | |                    ");
		System.out.println("|_  __  _| |__   _____      ____| | _____      ___ __  ");
		System.out.println(" _| || |_| '_ \\ / _ \\ \\ /\\ / / _` |/ _ \\ \\ /\\ / / '_ \\ ");
		System.out.println("|_  __  _| |_) | (_) \\ V  V / (_| | (_) \\ V  V /| | | |");
		System.out.println("  |_||_| |_.__/ \\___/ \\_/\\_/ \\__,_|\\___/ \\_/\\_/ |_| |_|");
                                                       
	}
	public static void blank(int lines) {
		// Starting with the counter at 0, I increment by 1 each time until it reaches 1 less than the parameter it was passed. Since I started at 0, a parameter of 3 goes {0,1,2,fail} resulting in 3 iterations.
		// I used a loop and made a husky too! :)
		for (int i=0; i<lines; i++) {
			System.out.println();
		}
	}
}
