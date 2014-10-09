#!/usr/bin/perl
$|=1;
$count = 0;
$pid = $$;
while (<>) {
        chomp $_;
        if ($_ =~ /(.*\.jpg)/i) {
                print "http://vpn.petrillifamily.com/images/whiteface.png\n";
        }
        elsif ($_ =~ /(.*\.gif)/i) {
                print "http://vpn.petrillifamily.com/images/whiteface.png\n";
        }
        elsif ($_ =~ /(.*\.png)/i) {
                print "http://vpn.petrillifamily.com/images/whiteface.png\n";
        }
        else {
                print "$_\n";;
        }
        $count++;
}
