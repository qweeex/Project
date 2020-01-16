public class Line {
    Point begin_Point;
    Point end_Point;

    public Line() {
        begin_Point = new Point();
        end_Point = new Point();
    }

    Line(int b_x, int b_y, int e_x, int e_y) {
        begin_Point = new Point(b_x, b_y);
        end_Point = new Point(e_x, e_y);
    }

    public String toString() {
        return "Линия от " + begin_Point.toString() + " до " + end_Point.toString();
    }
}
