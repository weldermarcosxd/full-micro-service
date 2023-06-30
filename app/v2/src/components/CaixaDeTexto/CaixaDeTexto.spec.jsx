import { screen, render } from "@testing-library/react";
import userEvent from "@testing-library/user-event";
import { CaixaDeTexto } from ".";

describe("<CaixaDeTexto />", () => {
  it("should render Caixa de Texto", () => {
    render(<CaixaDeTexto />);

    expect(screen.getByRole("searchbox")).toBeInTheDocument();
  });

  it("should have value of searchvalue", () => {
    const fn = jest.fn();
    render(<CaixaDeTexto value={"testando"} onChange={fn} />);

    const input = screen.getByPlaceholderText(/Digite a pesquisa/i);
    expect(input).toBeInTheDocument();
    expect(input.value).toBe("testando");
  });

  it("should call handlwChange on each key pressed", () => {
    const fn = jest.fn();
    render(<CaixaDeTexto onChange={fn} />);

    const input = screen.getByPlaceholderText(/Digite a pesquisa/i);
    const value = "valor escrito";

    userEvent.type(input, value);

    expect(input.value).toBe(value);
    expect(fn).toHaveBeenCalledTimes(value.length);
  });

  it("should match snapshot", () => {
    const fn = jest.fn();
    const { container } = render(<CaixaDeTexto value={"valor escrito"} onChange={fn} />);

    expect(container.firstChild).toMatchSnapshot();
  });
});
