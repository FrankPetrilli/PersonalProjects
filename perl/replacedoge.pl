#!/usr/bin/perl
$|=1;
$count = 0;
$pid = $$;
while (<>) {
        chomp $_;
        if ($_ =~ /(.*\.jpg)/i) {
                print "http://petrillifamily.com/images/doge.png\n";
        }
        elsif ($_ =~ /(.*\.gif)/i) {
                print "http://petrillifamily.com/images/doge.png\n";
        }
        elsif ($_ =~ /(.*\.png)/i) {
                print "http://petrillifamily.com/images/doge.png\n";
        }
        else {
                print "$_\n";;
        }
        $count++;
}
