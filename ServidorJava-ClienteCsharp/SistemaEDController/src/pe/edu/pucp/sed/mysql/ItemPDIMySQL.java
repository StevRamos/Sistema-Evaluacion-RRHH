    package pe.edu.pucp.sed.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.sed.config.DBManager;
import pe.edu.pucp.sed.dao.ItemPDIDAO;
import pe.edu.pucp.sed.model.ItemPDI;

public class ItemPDIMySQL implements ItemPDIDAO{

    Connection con;
    Statement st;
    PreparedStatement ps;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public int insertar(ItemPDI itemPDI) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_ITEM_PDI(?,?)}";
            cs = con.prepareCall(sql);

            cs.setString("_NOMBRE", itemPDI.getNombre());
            cs.registerOutParameter("_ID_ITEM", java.sql.Types.INTEGER);

            cs.executeUpdate();

            itemPDI.setIdItemPDI(cs.getInt("_ID_ITEM"));

            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int actualizar(ItemPDI itemPDI) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_ITEM_PDI(?,?)}";
            cs = con.prepareCall(sql);

            cs.setString("_NOMBRE", itemPDI.getNombre());
            cs.setInt("_ID_ITEM", itemPDI.getIdItemPDI());

            cs.executeUpdate();
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idItemPDI) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_ITEM_PDI(?)}";
            cs = con.prepareCall(sql);

            cs.setInt("_ID_ITEM_PDI", idItemPDI);

            cs.executeUpdate();
            resultado = 1;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<ItemPDI> listar() {
        ArrayList<ItemPDI> itemsPDI = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st = con.createStatement();
            String sql = "select * from ItemsPDI where activo = 1";
            rs = st.executeQuery(sql);
            while(rs.next()){
                ItemPDI item = new ItemPDI();
                item.setIdItemPDI(rs.getInt("id_ItemPDI"));
                item.setNombre(rs.getString("nombre"));
                
                itemsPDI.add(item);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return itemsPDI;
    }
}
