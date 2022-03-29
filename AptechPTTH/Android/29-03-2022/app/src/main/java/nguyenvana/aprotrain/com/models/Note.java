package nguyenvana.aprotrain.com.models;

import java.util.Date;
/*
CREATE TABLE Note(
    noidung TEXT,
    quantrong  INTEGER,
    ngaytao TEXT
)
*/


public class Note {
    private String noidung;
    private Boolean quantrong;
    private Date ngaytao; //ISO8601 strings ("YYYY-MM-DD HH:MM:SS.SSS").

    public Note(String noidung, Boolean quantrong, Date ngaytao) {
        this.noidung = noidung;
        this.quantrong = quantrong;
        this.ngaytao = ngaytao;
    }

    public String getNoidung() {
        return noidung;
    }

    public void setNoidung(String noidung) {
        this.noidung = noidung;
    }

    public Boolean getQuantrong() {
        return quantrong;
    }

    public void setQuantrong(Boolean quantrong) {
        this.quantrong = quantrong;
    }

    public Date getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(Date ngaytao) {
        this.ngaytao = ngaytao;
    }
}
