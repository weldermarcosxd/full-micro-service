import { render, screen } from "@testing-library/react";
import { Botao } from ".";
import userEvent from "@testing-library/user-event";

describe("<Botao />", () => {

    it("should render on screen with text", () => {
        render(<Botao text="Load More"></Botao>);
        expect.assertions(1);

        const botao = screen.getByRole("button", {name: /load more/i });
        expect(botao).toBeInTheDocument();
    });

    it("should call function on button click", () => {
        const fn = jest.fn();
        render(<Botao text="Load More" onClick={fn}></Botao>);
        expect.assertions(1);

        const botao = screen.getByRole("button", {name: /load more/i });
        userEvent.click(botao);

        expect(fn).toHaveBeenCalledTimes(1); 
    });

    it("should be disabled when disabled is true", () => {
        render(<Botao text="Load More" disabled={true}></Botao>);
        expect.assertions(1);

        const botao = screen.getByRole("button", {name: /load more/i });

        expect(botao).toBeDisabled();
    });

    it("should be enabled when disabled is false", () => {
        render(<Botao text="Load More"></Botao>);
        expect.assertions(1);

        const botao = screen.getByRole("button", {name: /load more/i });

        expect(botao).toBeEnabled();
    });

    it("should match snapshot", () => {
        const {container} = render(<Botao disabled={false} text="Load More"></Botao>);
        expect.assertions(1);
        expect(container.firstChild).toMatchSnapshot();
    });

});